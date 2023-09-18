using DirectShowLib;
using OpenCvSharp;
using OpenCvSharp.Aruco;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraDetection
{
    public partial class Form1 : Form
    {
        readonly Timer timer = new Timer();
        readonly ModuloCamera modCamera = new ModuloCamera();
        readonly VideoCapture videoCapture = new VideoCapture();

        class DeviceInfo
        {
            public int Index {  get; set; }
            public string Name {  get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            modCamera = new ModuloCamera();
            ListAllCameras();

            timer.Tick += Timer_Tick;

            trackBar1.Value = Properties.Settings.Default.FPS;

            try
            {
                videoCapture.Open(int.Parse(cbCam.SelectedValue.ToString()));
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var frame = new Mat();
           if (videoCapture.IsOpened())
            {
                videoCapture.Read(frame);
                //picCamOut.Width = frame.Width;
                //picCamOut.Height = frame.Height;
                if (chkPreview.Checked)
                {
                    picCamOut.Image = Image.FromStream(modCamera.DetectFeatures(frame).ToMemoryStream());
                }
                else
                {
                    picCamOut.Image = Image.FromStream(frame.ToMemoryStream());
                }

                var featCoord = modCamera.DetectFeaturesCoords(frame);
                if (featCoord.Count > 0)
                {
                    if (featCoord[0].Eyes.Length == 1)
                        lblFace.Text = featCoord[0].Eyes[0].ToString();
                    else
                    if (featCoord[0].Eyes.Length == 2)
                    {
                        lblFace.Text = featCoord[0].Eyes[0].ToString();
                        lblFace1.Text = featCoord[0].Eyes[1].ToString();
                    }

                }
                   
            }
        }

        private void ListAllCameras()
        {
            var dataSource = new List<DeviceInfo>();
            var videoSources = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < videoSources.Length; i++) 
            {
                dataSource.Add(new DeviceInfo() { Name = videoSources[i].Name, Index = i });
            }

            cbCam.DataSource = dataSource;
            cbCam.DisplayMember = "Name";
            cbCam.ValueMember = "Index";

            if (cbCam.Items.Count > 0) cbCam.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            modCamera.Release();
            videoCapture.Release();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (videoCapture.IsOpened())
            {
                videoCapture.Release();
            }
            if (!videoCapture.IsOpened()) {
                videoCapture.Open(int.Parse(cbCam.SelectedValue.ToString()));
                if (videoCapture.Fps > 0)
                    trackBar1.Value = (int)videoCapture.Fps;
            }
            timer.Start();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lblFps.Text = "Capturar em FPS: " + trackBar1.Value.ToString();
            timer.Interval = (int)(1000 / (double)trackBar1.Value);

            Properties.Settings.Default.FPS = trackBar1.Value;
            Properties.Settings.Default.Save();
        }
    }
}
