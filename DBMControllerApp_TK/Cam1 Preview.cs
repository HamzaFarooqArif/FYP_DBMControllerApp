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

            placePoints();

        }

        private void placePoints()
        {
            if (MouseUtility.getInstance(0).points.Length > 0) MouseUtility.getInstance(0).insertPoint(Properties.Settings.Default.Cam1_Point1);
            if (MouseUtility.getInstance(0).points.Length > 1) MouseUtility.getInstance(0).insertPoint(Properties.Settings.Default.Cam1_Point2);
            if (MouseUtility.getInstance(0).points.Length > 2) MouseUtility.getInstance(0).insertPoint(Properties.Settings.Default.Cam1_Point3);
        }

        public void processFrame(object sender, EventArgs arg)
        {
            IndexForm.capture0.Retrieve(frame, 0);
            Image<Bgr, Byte> frame1 = frame.Clone().ToImage<Bgr, byte>();
            frame1._SmoothGaussian(11);
            Image<Hsv, byte> frame1HSV = frame1.Convert<Hsv, byte>();
            CvInvoke.InRange(frame1HSV, new ScalarArray(new MCvScalar(CentralClass.getInstance().lower1.H, CentralClass.getInstance().lower1.S, CentralClass.getInstance().lower1.V)),
                           new ScalarArray(new MCvScalar(CentralClass.getInstance().upper1.H, CentralClass.getInstance().upper1.S, CentralClass.getInstance().upper1.V)), frame1HSV);
            var element1 = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            CvInvoke.Erode(frame1HSV, frame1HSV, element1, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            CvInvoke.Dilate(frame1HSV, frame1HSV, element1, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            //CvInvoke.Imshow("Dilate1", frame1HSV);
            Emgu.CV.Util.VectorOfVectorOfPoint contours1 = new Emgu.CV.Util.VectorOfVectorOfPoint();
            CvInvoke.FindContours(frame1HSV, contours1, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            Image<Gray, byte> imgout1 = new Image<Gray, byte>(frame1HSV.Width, frame1HSV.Height, new Gray(0));
            Image<Gray, byte> imgCircle1 = new Image<Gray, byte>(frame1HSV.Width, frame1HSV.Height, new Gray(0));
            CvInvoke.DrawContours(imgout1, contours1, -1, new MCvScalar(255, 0, 0));
            Point center1 = new Point();
            if (contours1.Size > 0)
            {
                double prevSize = 0;
                int idx = 0;

                for (int i = 0; i < contours1.Size; i++)
                {
                    if (CvInvoke.ContourArea(contours1[i]) > prevSize)
                    {
                        prevSize = CvInvoke.ContourArea(contours1[i]);
                        idx = i;
                    }
                }

                CircleF circle = CvInvoke.MinEnclosingCircle(contours1[idx]);
                Moments M = CvInvoke.Moments(contours1[idx]);
                center1 = new Point((int)(M.M10 / M.M00), (int)(M.M01 / M.M00));

                if (circle.Radius > 10)
                {
                    CvInvoke.Circle(frame, center1, (int)circle.Radius, new MCvScalar(255, 0, 0), 5);
                    CvInvoke.Circle(frame, center1, 5, new MCvScalar(0, 0, 255), 5);
                }
            }

            CvInvoke.Circle(frame, center1, 1, new MCvScalar(0, 0, 255), 2);
            for (int i = 0; i < MouseUtility.getInstance(0).idx; i++)
            {
                Point center = new Point((int)MouseUtility.getInstance(0).points[i].X, (int)MouseUtility.getInstance(0).points[i].Y);
                CvInvoke.Circle(frame, center, 1, new MCvScalar(0, 0, 255), 2);
            }
            if (MouseUtility.getInstance(0).idx > 1)
            {
                CvInvoke.Line(frame, MouseUtility.getInstance(0).points[0], MouseUtility.getInstance(0).points[1], new MCvScalar(0, 0, 255));
                if (MouseUtility.getInstance(0).idx > 2)
                {
                    Point p1 = MouseUtility.getInstance(0).getPerpEndPoints(frame.Rows, frame.Cols, MouseUtility.getInstance(0).points[0], MouseUtility.getInstance(0).points[1], MouseUtility.getInstance(0).points[2])[0];
                    Point q1 = MouseUtility.getInstance(0).getPerpEndPoints(frame.Rows, frame.Cols, MouseUtility.getInstance(0).points[0], MouseUtility.getInstance(0).points[1], MouseUtility.getInstance(0).points[2])[1];
                    CvInvoke.Line(frame, p1, q1, new MCvScalar(0, 0, 255));

                    Point p2 = MouseUtility.getInstance(0).getDistPoints(frame.Rows, frame.Cols, p1, q1, center1)[0];
                    Point q2 = MouseUtility.getInstance(0).getDistPoints(frame.Rows, frame.Cols, p1, q1, center1)[1];
                    CvInvoke.Line(frame, p2, q2, new MCvScalar(0, 0, 255));

                    if (MouseUtility.getInstance(0).directionOfPoint(p1, q1, center1) == 1)
                    {
                        MouseUtility.getInstance(0).position = -MouseUtility.getInstance(0).percent(MouseUtility.getInstance(0).distance(p2, q2), MouseUtility.getInstance(0).distance(MouseUtility.getInstance(0).points[0], MouseUtility.getInstance(0).points[2]));
                    }
                    if (MouseUtility.getInstance(0).directionOfPoint(p1, q1, center1) < 1)
                    {
                        MouseUtility.getInstance(0).position = MouseUtility.getInstance(0).percent(MouseUtility.getInstance(0).distance(p2, q2), MouseUtility.getInstance(0).distance(MouseUtility.getInstance(0).points[1], MouseUtility.getInstance(0).points[2]));
                    }
                }
            }
            
            imageBox1.Image = frame;
        }

        private void imageBox1_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coord = me.Location;

            if (MouseUtility.getInstance(0).idx > 1)
            {
                double m = (double)(MouseUtility.getInstance(0).points[1].Y - MouseUtility.getInstance(0).points[0].Y) / (double)(MouseUtility.getInstance(0).points[1].X - MouseUtility.getInstance(0).points[0].X);
                int c = (int)(MouseUtility.getInstance(0).points[1].Y - (m * MouseUtility.getInstance(0).points[1].X));

                for (int i = 0; i < imageBox1.Height; i++)
                {
                    if ((i == (int)(m * coord.X + c)))
                    {
                        coord.Y = i;
                        break;
                    }
                }
            }
            MouseUtility.getInstance(0).insertPoint(coord.X, coord.Y);
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (MouseUtility.getInstance(0).idx > 0)
            {
                MouseUtility.getInstance(0).idx--;
            }
        }

        private void Cam1_Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(MouseUtility.getInstance(0).idx < 3)
            {
                MessageBox.Show("Insufficient Points!");
                return;
            }
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to save settings?", "Save Settings", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.Cam1_Point1 = MouseUtility.getInstance(0).points[0];
                Properties.Settings.Default.Cam1_Point2 = MouseUtility.getInstance(0).points[1];
                Properties.Settings.Default.Cam1_Point3 = MouseUtility.getInstance(0).points[2];
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings Saved");
            }
            
        }
    }
}
