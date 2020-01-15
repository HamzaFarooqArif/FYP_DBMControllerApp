using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace DBMControllerApp_TK.Forms
{
    public partial class FilterPreview : Form
    {
        public static List<FilterPreview> _instance;
        public int formIdx;
        private bool showMask;
        public int offset;
        private int pointLimit;
        private Point mainPoint;
        private Point hoverPoint;
        private Mat localFrame;
        public List<Point> points { get; set; }
        public static FilterPreview getInstance(int idx)
        {
            if (_instance == null)
            {
                _instance = new List<FilterPreview>();
            }
            while (_instance.Count - 1 < idx)
            {
                _instance.Add(new FilterPreview());
            }
            return _instance[idx];
        }
        private FilterPreview()
        {
            InitializeComponent();
            localFrame = new Mat();
            showMask = false;
            pointLimit = 3;
            offset = 0;
            mainPoint = new Point(-1, -1);
            hoverPoint = new Point();
            points = new List<Point>();
            formIdx = _instance.Count;
            this.Text = "Filter Preview " + (formIdx + 1);
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
            Application.Idle += idleEvent;
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            tb_Offset.Text = offset.ToString();
        }
        public void setImage(Mat frame)
        {
            localFrame = frame;
            mainPoint = detectCircle(ref localFrame);
            placePoint(ref localFrame, hoverPoint);
            drawTemplate(ref localFrame, points, mainPoint);
            ib_Preview.Image = localFrame;
        }
        private Point detectCircle(ref Mat frame)
        {
            Image<Bgr, byte> frameImg = frame.ToImage<Bgr, byte>();
            frameImg._SmoothGaussian(11);
            Image<Hsv, byte> frameHSV = frameImg.Convert<Hsv, byte>();
            CvInvoke.InRange(frameHSV, new ScalarArray(new MCvScalar(FilterSettings.getInstance(formIdx).lower.H, FilterSettings.getInstance(formIdx).lower.S, FilterSettings.getInstance(formIdx).lower.V)),
                           new ScalarArray(new MCvScalar(FilterSettings.getInstance(formIdx).upper.H, FilterSettings.getInstance(formIdx).upper.S, FilterSettings.getInstance(formIdx).upper.V)), frameHSV);
            var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            CvInvoke.Erode(frameHSV, frameHSV, element, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            CvInvoke.Dilate(frameHSV, frameHSV, element, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
            VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            CvInvoke.FindContours(frameHSV, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            Image<Gray, byte> imgout = new Image<Gray, byte>(frameHSV.Width, frameHSV.Height, new Gray(0));
            Image<Gray, byte> imgCircle = new Image<Gray, byte>(frameHSV.Width, frameHSV.Height, new Gray(0));
            CvInvoke.DrawContours(imgout, contours, -1, new MCvScalar(255, 0, 0));
            Point center = new Point();
            if (contours.Size > 0)
            {
                double prevSize = 0;
                int idx = 0;

                for (int i = 0; i < contours.Size; i++)
                {
                    if (CvInvoke.ContourArea(contours[i]) > prevSize)
                    {
                        prevSize = CvInvoke.ContourArea(contours[i]);
                        idx = i;
                    }
                }

                CircleF circle = CvInvoke.MinEnclosingCircle(contours[idx]);
                Moments M = CvInvoke.Moments(contours[idx]);
                center = new Point((int)(M.M10 / M.M00), (int)(M.M01 / M.M00));

                if (circle.Radius > 10)
                {
                    CvInvoke.Circle(frame, center, (int)circle.Radius, new MCvScalar(255, 0, 0), 5);
                    CvInvoke.Circle(frame, center, 5, new MCvScalar(0, 0, 255), 5);
                    CvInvoke.Circle(frameHSV, center, (int)circle.Radius, new MCvScalar(255, 0, 0), 5);
                    CvInvoke.Circle(frameHSV, center, 5, new MCvScalar(255, 0, 0), 5);
                }
            }
            if(showMask) frame = frameHSV.Mat;
            return center;
        }
        public void startAll()
        {
            ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void stopAll()
        {
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void FilterPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ib_Preview_DoubleClick(object sender, EventArgs e)
        {
            insertPoint(hoverPoint);
        }
        public bool insertPoint(Point p)
        {
            return insertPoint(p.X, p.Y);
        }
        public bool insertPoint(int x, int y)
        {
            if (points.Count < pointLimit)
            {
                points.Add(new Point(x, y));
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if(points.Count > 0) points.RemoveAt(points.Count - 1);
        }

        private void ib_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            hoverPoint.X = (int)Map(e.X, 0, ib_Preview.Width, 0, localFrame.Width);
            hoverPoint.Y = (int)Map(e.Y, 0, ib_Preview.Height, 0, localFrame.Height);
        }

        private void ib_Preview_MouseLeave(object sender, EventArgs e)
        {
            hoverPoint = new Point(-1, -1);
        }

        private void drawTemplate(ref Mat frame, List<Point> pointsList, Point mainPoint)
        {
            placePoints(ref localFrame, points);
            if (pointsList.Count > 1)
            {
                drawIndefLine(ref frame, pointsList[0], pointsList[1]);
                if (pointsList.Count > 2)
                {
                    List<Point> pointsList_1 = getPerpEndPoints(ref frame, pointsList[0], pointsList[1], pointsList[2]);
                    drawIndefLine(ref frame, pointsList_1[0], pointsList_1[1]);
                    if(mainPoint.X > -1 && mainPoint.Y > -1)
                    {
                        List<Point> pointsList_2 = getDistPoints(ref frame, pointsList_1[0], pointsList_1[1], mainPoint);
                        drawLine(ref frame, pointsList_2[0], pointsList_2[1]);

                        List<Point> horizEndPoints = getEndPoints(ref frame, pointsList[0], pointsList[1]);
                        List<Point> vertEndPoints = pointsList_1;
                        Point midPoint = findIntercept(horizEndPoints[0], horizEndPoints[1], vertEndPoints[0], vertEndPoints[1]);
                        int leftDist = distance(horizEndPoints[0], midPoint);
                        int rightDist = distance(horizEndPoints[1], midPoint);
                        int dist = distance(pointsList_2[0], pointsList_2[1]);
                        if (distance(pointsList_2[1], horizEndPoints[0]) > distance(mainPoint, horizEndPoints[0]))
                        {
                            offset = (int)percent(dist, leftDist);
                        }
                        else
                        {
                            offset = -(int)percent(dist, rightDist);
                        }
                    }
                    else
                    {
                        offset = 0;
                    }
                }
                else
                {
                    offset = 0;
                }   
            }
        }
        private void drawLine(ref Mat frame, Point p1, Point p2)
        {
            CvInvoke.Line(frame, p1, p2, new MCvScalar(0, 0, 255));
        }
        private void drawIndefLine(ref Mat frame, Point p1, Point p2)
        {
            List<Point> endPoints = getEndPoints(ref frame, p1, p2);
            drawLine(ref frame, endPoints[0], endPoints[1]);
        }
        public List<Point> getEndPoints(ref Mat frame, Point p1, Point p2)
        {
            int rows = frame.Rows;
            int cols = frame.Cols;
            Point p = new Point(-1, -1);
            Point q = new Point(-1, -1);

            Point r1 = doIntercept(0, rows, cols, p1, p2);
            Point r2 = doIntercept(1, rows, cols, p1, p2);
            Point r3 = doIntercept(2, rows, cols, p1, p2);
            Point r4 = doIntercept(3, rows, cols, p1, p2);

            if (isValidPoint(ref frame, r1))
            {
                setPoint(ref p, ref q, r1.X, r1.Y);
            }
            if (isValidPoint(ref frame, r2))
            {
                setPoint(ref p, ref q, r2.X, r2.Y);
            }
            if (isValidPoint(ref frame, r3))
            {
                setPoint(ref p, ref q, r3.X, r3.Y);
            }
            if (isValidPoint(ref frame, r4))
            {
                setPoint(ref p, ref q, r4.X, r4.Y);
            }

            List<Point> result = new List<Point>();
            result.Add(p);
            result.Add(q);

            return result;
        }
        public Point doIntercept(int lineIndex, int rows, int cols, Point p1, Point p2)
        {
            double m1 = (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
            int c1 = (int)(p1.Y - (m1 * p1.X));

            Point p = new Point(-1, -1);

            if (lineIndex == 0)
            {
                double x;
                double y;
                if (double.IsInfinity(m1))
                {
                    x = p1.X;
                    y = 0;
                }
                else
                {
                    double m2 = 0;
                    int c2 = 0;
                    x = (c2 - c1) / (m1 - m2);
                    y = (c1 * m2 - c2 * m1) / (m2 - m1);
                }
                p.X = (int)x;
                p.Y = (int)y;

                if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
                {
                    return p;
                }
            }
            if (lineIndex == 1)
            {
                double x = cols;
                double y = m1 * (cols) + c1;

                p.X = (int)x;
                p.Y = (int)y;

                if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
                {
                    return p;
                }
            }
            if (lineIndex == 2)
            {
                double x;
                double y;
                if (double.IsInfinity(m1))
                {
                    x = p1.X;
                    y = rows;
                }
                else
                {
                    double m2 = 0;
                    int c2 = rows;

                    x = (c2 - c1) / (m1 - m2);
                    y = (c1 * m2 - c2 * m1) / (m2 - m1);
                }
                p.X = (int)x;
                p.Y = (int)y;

                if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
                {
                    return p;
                }
            }
            if (lineIndex == 3)
            {
                double x = 0;
                double y = m1 * 0 + c1;

                p.X = (int)x;
                p.Y = (int)y;

                if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
                {
                    return p;
                }
            }
            p.X = -1;
            p.Y = -1;
            return p;
        }
        public bool isValidPoint(ref Mat frame, Point p)
        {
            int rows = frame.Rows;
            int cols = frame.Cols;
            if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
            {
                return true;
            }
            return false;
        }
        public void setPoint(ref Point p, ref Point q, int x, int y)
        {
            if (!isAssigned(p))
            {
                p.X = x;
                p.Y = y;
            }
            else if (!isAssigned(q))
            {
                q.X = x;
                q.Y = y;
            }
        }
        public bool isAssigned(Point p)
        {
            return p.X != -1 && p.Y != -1;
        }
        public List<Point> getPerpEndPoints(ref Mat frame, Point p1, Point p2, Point p3)
        {
            int rows = frame.Rows;
            int cols = frame.Cols;

            double slope = (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
            double m = -1 / (slope);
            int c = (int)(p3.Y - (m * p3.X));
            Point p4 = new Point();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if ((j == (int)(m * i + c)) && p3.X != i && p3.Y != j)
                    {
                        p4.X = i;
                        p4.Y = j;
                        break;
                    }
                }
            }
            if (p4.X == 0 && p4.Y == 0)
            {
                p4.X = p3.X;
                p4.Y = 0;
            }

            return getEndPoints(ref frame, p3, p4);
        }
        public List<Point> getDistPoints(ref Mat frame, Point p1, Point p2, Point p3)
        {
            int rows = frame.Rows;
            int cols = frame.Cols;

            double m1 = (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
            int c1 = (int)(p1.Y - (m1 * p1.X));
            double m2 = -1 / m1;
            int c2 = (int)(p3.Y - (m2 * p3.X));

            double x;
            double y;

            x = (c2 - c1) / (m1 - m2);
            y = (c1 * m2 - c2 * m1) / (m2 - m1);

            Point p = new Point((int)x, (int)y);
            //Point p4 = new Point(-1, p3.Y);
            //double m = (double)(p2.Y - p1.Y) / (double)(p2.X - p1.X);
            //int c = (int)(p1.Y - (m * p1.X));
            //double x;
            //if (double.IsInfinity(m))
            //{
            //    x = p1.X;
            //}
            //else
            //{
            //    x = (p4.Y - c) / m;
            //}
            //p4.X = (int)x;

            List<Point> result = new List<Point>();
            result.Add(p3);
            result.Add(p);

            return result;
        }
        public int distance(Point p, Point q)
        {
            int xDiff = p.X - q.X;
            int yDiff = p.Y - q.Y;

            int result = (int)Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));

            return result;
        }
        public float percent(int obtained, int total)
        {
            float result = (float)obtained / (float)total;
            result *= 100;
            return result;
        }
        public Point findIntercept(Point l1p1, Point l1p2, Point l2p1, Point l2p2)
        {
            double m1 = (l1p2.Y - l1p1.Y) / (l1p2.X - l1p1.X);
            double c1 = (l1p2.Y - m1 * l1p2.X);

            double m2 = (l2p2.Y - l2p1.Y) / (l2p2.X - l2p1.X);
            double c2 = (l2p2.Y - m2 * l2p2.X);

            int x = (int)((c2 - c1) / (m1 - m2));
            int y = (int)(m1 * x + c1);

            Point result = new Point(x, y);

            return result;
        }
        public float Map(float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
        private void placePoint(ref Mat frame, Point p)
        {
            CvInvoke.Circle(frame, p, 1, new MCvScalar(0, 0, 255), 2);
        }
        private void placePoints(ref Mat frame, List<Point> pointsList)
        {
            foreach (Point p in pointsList)
            {
                placePoint(ref frame, p);
            }
        }

        private void btn_ShowMask_Click(object sender, EventArgs e)
        {
            if(showMask)
            {
                btn_ShowMask.Text = "Show Mask";
            }
            else
            {
                btn_ShowMask.Text = "Hide Mask";
            }
            showMask = !showMask;
        }
    }
}
