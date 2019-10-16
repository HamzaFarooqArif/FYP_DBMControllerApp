using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;
using DBMControllerApp_TK.Utilities;

namespace DBMControllerApp_TK
{
    public partial class Cam1_Preview : Form
    {
        private static Cam1_Preview instance;
        public Mat frame;
        public static Cam1_Preview getInstance()
        {
            if (instance == null)
            {
                instance = new Cam1_Preview();
            }
            return instance;
        }
        public Cam1_Preview()
        {
            InitializeComponent();
            frame = new Mat();
        }

        public void processFrame(object sender, EventArgs arg)
        {
            Form1.capture0.Retrieve(frame, 0);
            Image<Bgr, Byte> frame1 = frame.Clone().ToImage<Bgr, byte>();
            frame1._SmoothGaussian(11);
            Image<Hsv, byte> frame1HSV = frame1.Convert<Hsv, byte>();
            CvInvoke.InRange(frame1HSV, new ScalarArray(new MCvScalar(CentralClass.getInstance().lower1.H, CentralClass.getInstance().lower1.S, CentralClass.getInstance().lower1.V)),
                           new ScalarArray(new MCvScalar(CentralClass.getInstance().upper1.H, CentralClass.getInstance().upper1.S, CentralClass.getInstance().upper1.V)), frame1HSV);


            //CvInvoke.InRange(frame1HSV, new ScalarArray(new MCvScalar(Cam_FilterProp.getInstance(0).lower.H, Cam_FilterProp.getInstance(0).lower.S, Cam_FilterProp.getInstance(0).lower.V)),
            //               new ScalarArray(new MCvScalar(Cam_FilterProp.getInstance(0).upper.H, Cam_FilterProp.getInstance(0).upper.S, Cam_FilterProp.getInstance(0).upper.V)), frame1HSV);


            imageBox1.Image = frame1HSV;

            //Image<Hsv, byte> frame1HSV = frame1Copy.Convert<Hsv, byte>();
            //CvInvoke.InRange(frame1HSV, new ScalarArray(new MCvScalar(Cam_FilterProp.getInstance(0).lower.H, Cam_FilterProp.getInstance(0).lower.S, Cam_FilterProp.getInstance(0).lower.V)),
            //               new ScalarArray(new MCvScalar(Cam_FilterProp.getInstance(0).upper.H, Cam_FilterProp.getInstance(0).upper.S, Cam_FilterProp.getInstance(0).upper.V)), frame1HSV);




            //var element1 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            //CvInvoke.Erode(frame1HSV, frame1HSV, element1, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            //CvInvoke.Dilate(frame1HSV, frame1HSV, element1, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            ////CvInvoke.Imshow("Dilate1", frame1HSV);
            //Emgu.CV.Util.VectorOfVectorOfPoint contours1 = new Emgu.CV.Util.VectorOfVectorOfPoint();
            //CvInvoke.FindContours(frame1HSV, contours1, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            //Image<Gray, byte> imgout1 = new Image<Gray, byte>(frame1HSV.Width, frame1HSV.Height, new Gray(0));
            //Image<Gray, byte> imgCircle1 = new Image<Gray, byte>(frame1HSV.Width, frame1HSV.Height, new Gray(0));
            //CvInvoke.DrawContours(imgout1, contours1, -1, new MCvScalar(255, 0, 0));
            //Point center1 = new Point();
            //if (contours1.Size > 0)
            //{
            //    double prevSize = 0;
            //    int idx = 0;

            //    for (int i = 0; i < contours1.Size; i++)
            //    {
            //        if (CvInvoke.ContourArea(contours1[i]) > prevSize)
            //        {
            //            prevSize = CvInvoke.ContourArea(contours1[i]);
            //            idx = i;
            //        }
            //    }

            //    CircleF circle = CvInvoke.MinEnclosingCircle(contours1[idx]);
            //    Moments M = CvInvoke.Moments(contours1[idx]);
            //    center1 = new Point((int)(M.M10 / M.M00), (int)(M.M01 / M.M00));

            //    if (circle.Radius > 10)
            //    {
            //        CvInvoke.Circle(frame1, center1, (int)circle.Radius, new MCvScalar(255, 0, 0), 5);
            //        CvInvoke.Circle(frame1, center1, 5, new MCvScalar(0, 0, 255), 5);
            //    }
            //}











        }
    }
}
