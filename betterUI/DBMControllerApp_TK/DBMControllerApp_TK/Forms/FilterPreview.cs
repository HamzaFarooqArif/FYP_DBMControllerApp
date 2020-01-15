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
namespace DBMControllerApp_TK.Forms
{
    public partial class FilterPreview : Form
    {
        public static List<FilterPreview> _instance;
        public int formIdx;
        public int pointLimit;
        public Point mainPoint;
        public Point hoverPoint;
        public Mat localFrame;
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
            pointLimit = 3;
            mainPoint = new Point();
            hoverPoint = new Point();
            points = new List<Point>();
            formIdx = _instance.Count;
            this.Text = "Filter Preview " + (formIdx + 1);
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void setImage(Mat frame)
        {
            localFrame = frame;
            placePoint(ref localFrame, hoverPoint);
            drawTemplate(ref localFrame, points);
            ib_Preview.Image = localFrame;
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

        private void placePoints(ref Mat frame, List<Point> pointsList)
        {
            foreach(Point p in pointsList)
            {
                placePoint(ref frame, p);
            }
        }

        private void placePoint(ref Mat frame, Point p)
        {
            CvInvoke.Circle(frame, p, 1, new MCvScalar(0, 0, 255), 2);
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
        public float Map(float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        private void ib_Preview_MouseLeave(object sender, EventArgs e)
        {
            hoverPoint = new Point();
        }

        private void drawLine(ref Mat frame, Point p1, Point p2)
        {
            CvInvoke.Line(frame, p1, p2, new MCvScalar(0, 0, 255));
        }

        private void drawTemplate(ref Mat frame, List<Point> pointsList)
        {
            placePoints(ref localFrame, points);
            if (pointsList.Count > 1)
            {
                drawIndefLine(ref frame, pointsList[0], pointsList[1]);
            }
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

    }
}
