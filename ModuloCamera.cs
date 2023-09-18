using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CameraDetection
{
    internal class ModuloCamera
    {
        CascadeClassifier face_cascade;
        CascadeClassifier eyes_cascade;

        public class FaceFeature
        {
            public Rect Face { get; set; }
            public Rect[] Eyes { get; set; }
        }
        List<FaceFeature> features = new List<FaceFeature>();

        public ModuloCamera()
        {
            //Define the face and eyes classifies using Haar-cascade xml
            //Download location: https://github.com/opencv/opencv/tree/master/data/haarcascades
            face_cascade = new CascadeClassifier(AppDomain.CurrentDomain.BaseDirectory + "/Cascades/haarcascade_frontalface_default.xml");
            eyes_cascade = new CascadeClassifier(AppDomain.CurrentDomain.BaseDirectory + "/Cascades/haarcascade_eye.xml");
        }

        private Mat ConvertGrayScale(Mat image)
        {
            Mat gray = new Mat();
            Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);
            return gray;
        }

        public void Release()
        {
            Cv2.DestroyAllWindows();
        }

        private Rect[] DetectFaces(Mat image)
        {
            Rect[] faces = face_cascade.DetectMultiScale(image, 1.1, 3);
            return faces;
        }

        private Rect[] DetectEyes(Mat image)
        {
            Rect[] eyes = eyes_cascade.DetectMultiScale(image);
            return eyes;
        }
        private void MarkFeatures(Mat image)
        {
            foreach (FaceFeature feature in features)
            {
                Cv2.Rectangle(image, feature.Face, new Scalar(0, 255, 0), thickness: 1);
                var face_region = image[feature.Face];
                foreach (var eye in feature.Eyes)
                {
                    Cv2.Rectangle(face_region, eye, new Scalar(255, 0, 0), thickness: 1);
                }
            }
        }

        public List<FaceFeature> DetectFeaturesCoords(Mat image)
        {
            ConvertGrayScale(image);

            Rect[] faces = DetectFaces(image);
            if (image.Empty())
                return new List<FaceFeature>(); ;

            features = new List<FaceFeature>();
            foreach (var item in faces)
            {
                Mat face_roi = image[item];
                Rect[] eyes = DetectEyes(face_roi);

                features.Add(new FaceFeature()
                {
                    Face = item,
                    Eyes = eyes
                });
            }

            MarkFeatures(image);
            return features;
        }

        public Mat DetectFeatures(Mat image)
        {
            ConvertGrayScale(image);

            Rect[] faces = DetectFaces(image);
            if (image.Empty())
                return image;

            features = new List<FaceFeature>();
            foreach (var item in faces)
            {
                Mat face_roi = image[item];
                Rect[] eyes = DetectEyes(face_roi);

                features.Add(new FaceFeature()
                {
                    Face = item,
                    Eyes = eyes
                });
            }

            MarkFeatures(image);
            return image;
        }
    }
}
