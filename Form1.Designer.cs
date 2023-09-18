namespace CameraDetection
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCam = new System.Windows.Forms.ComboBox();
            this.lblCam = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCamOut = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblFps = new System.Windows.Forms.Label();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.lblFace1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCam
            // 
            this.cbCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCam.FormattingEnabled = true;
            this.cbCam.Location = new System.Drawing.Point(796, 28);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(179, 21);
            this.cbCam.TabIndex = 1;
            // 
            // lblCam
            // 
            this.lblCam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCam.AutoSize = true;
            this.lblCam.Location = new System.Drawing.Point(796, 12);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(43, 13);
            this.lblCam.TabIndex = 2;
            this.lblCam.Text = "Camera";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.Location = new System.Drawing.Point(796, 118);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(179, 23);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Recarregar Camera";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picCamOut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 572);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // picCamOut
            // 
            this.picCamOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCamOut.Location = new System.Drawing.Point(6, 19);
            this.picCamOut.Name = "picCamOut";
            this.picCamOut.Size = new System.Drawing.Size(766, 547);
            this.picCamOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamOut.TabIndex = 7;
            this.picCamOut.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(796, 72);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(179, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 30;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblFps
            // 
            this.lblFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(796, 56);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(105, 13);
            this.lblFps.TabIndex = 9;
            this.lblFps.Text = "Capturar em FPS: 30";
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(799, 561);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(96, 17);
            this.chkPreview.TabIndex = 10;
            this.chkPreview.Text = "Cam / Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // lblFace
            // 
            this.lblFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(796, 512);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(95, 13);
            this.lblFace.TabIndex = 12;
            this.lblFace.Text = "Dados Rastreados";
            // 
            // lblFace1
            // 
            this.lblFace1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFace1.AutoSize = true;
            this.lblFace1.Location = new System.Drawing.Point(796, 531);
            this.lblFace1.Name = "lblFace1";
            this.lblFace1.Size = new System.Drawing.Size(95, 13);
            this.lblFace1.TabIndex = 13;
            this.lblFace1.Text = "Dados Rastreados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 596);
            this.Controls.Add(this.lblFace1);
            this.Controls.Add(this.lblFace);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblCam);
            this.Controls.Add(this.cbCam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCamOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCam;
        private System.Windows.Forms.Label lblCam;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCamOut;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.Label lblFace1;
    }
}

