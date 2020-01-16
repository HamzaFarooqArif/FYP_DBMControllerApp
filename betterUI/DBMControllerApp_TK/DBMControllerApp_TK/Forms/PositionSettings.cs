using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMControllerApp_TK.Forms
{
    public partial class PositionSettings : Form
    {
        private static PositionSettings _instance;
        private bool invertLeftPos;
        private bool invertRightPos;
        private int boardWidth;
        private int boardHeight;
        public Point tipOffset;
        public static PositionSettings getInstance()
        {
            if (_instance == null)
            {
                _instance = new PositionSettings();
            }
            return _instance;
        }
        private PositionSettings()
        {
            InitializeComponent();
            boardWidth = 480;
            boardHeight = 320;
            invertRightPos = false;
            invertRightPos = false;
            tipOffset = new Point();
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;

            Application.Idle += idleEvent;
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            float sizeFactor = 0.5f;
            Image<Bgr, byte> boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);
            Point line1p1 = new Point((int)((float)boardWidth * (float)0.1), (int)((float)boardHeight * (float)0.1));
            Point line1p2 = new Point(boardWidth, boardHeight);
            Point line2p1 = new Point((int)((float)boardWidth * (float)0.9), (int)((float)boardHeight * (float)0.1));
            Point line2p2 = new Point(0, boardHeight);
            if (invertLeftPos) line1p2 = rotate(line1p2, line1p1, (float)11.5 + getAngleFromPercent(FilterPreview.getInstance(0).offset));
            else line1p2 = rotate(line1p2, line1p1, (float)11.5 - getAngleFromPercent(FilterPreview.getInstance(0).offset));
            if (invertRightPos) line2p2 = rotate(line2p2, line2p1, (float)-11.5 - getAngleFromPercent(FilterPreview.getInstance(1).offset));
            else line2p2 = rotate(line2p2, line2p1, (float)-11.5 + getAngleFromPercent(FilterPreview.getInstance(1).offset));
            CvInvoke.Circle(boardFrame, line1p1, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line1p2, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line2p1, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line2p2, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Line(boardFrame, line1p1, line1p2, new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, line2p1, line2p2, new MCvScalar(255, 255, 255));
            PointF notNeedp1 = new PointF();
            PointF notNeedp2 = new PointF();
            PointF p3 = new PointF();
            bool notNeeda;
            bool notNeedb;
            FindIntersection(line1p1, line1p2, line2p1, line2p2, out notNeeda, out notNeedb, out p3, out notNeedp1, out notNeedp2);
            Point position = new Point((int)p3.X, (int)p3.Y);
            CvInvoke.Circle(boardFrame, position, 5, new MCvScalar(255, 0, 0), 2);
            double calibX = simplifyAngle(demo3d.calibX);
            double calibY = simplifyAngle(demo3d.calibY);
            double calibZ = simplifyAngle(demo3d.calibZ);
            Vector3d markerVect = new Vector3d(0, 0, 100);
            markerVect = rotateX(markerVect, calibX);
            markerVect = rotateY(markerVect, calibY);
            //markerVect = MouseUtility.rotateZ(markerVect, calibZ);
            markerVect.X = markerVect.X * sizeFactor;
            markerVect.Y = markerVect.Y * sizeFactor;
            markerVect.Z = markerVect.Z * sizeFactor;
            Point actualPosition = new Point(drawVector(markerVect, position.X, position.Y).Item2.X, drawVector(markerVect, position.X, position.Y).Item2.Y);
            CvInvoke.Line(boardFrame, position, actualPosition, new MCvScalar(0, 0, 255), 2);
            if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(0, 0, 255), 1);
            else CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(255, 0, 0), 1);
            tipOffset.X = (int)markerVect.X;
            tipOffset.Y = (int)markerVect.Y;
            tb_Offset.Text = actualPosition.ToString();
            ib_Preview.Image = boardFrame;
        }
        public static Tuple<Point, Point> drawVector(Vector3d vector, int oX, int oY)
        {
            Point origin = new Point(oX, oY);
            Point point = new Point((int)(vector.X + oX), (int)(-vector.Y + oY));
            return new Tuple<Point, Point>(origin, point);
        }

        public static double simplifyAngle(double angle)
        {
            if (angle >= 360) return angle - 360;
            if (angle <= -360) return angle + 360;
            if (angle <= 0) return angle + 360;
            return angle;
        }
        public static Vector3d rotateX(Vector3d vector, double angle)
        {
            return rotateX(vector.X, vector.Y, vector.Z, angle);
        }
        public static Vector3d rotateX(double x, double y, double z, double angle)
        {
            double theta = angle * (Math.PI / 180);

            double newX = x;
            double newY = y * Math.Cos(theta) - z * Math.Sin(theta);
            double newZ = y * Math.Sin(theta) + z * Math.Cos(theta);

            Vector3d result = new Vector3d(newX, newY, newZ);

            return result;
        }
        public static Vector3d rotateY(double x, double y, double z, double angle)
        {
            double theta = angle * (Math.PI / 180);

            double newX = x * Math.Cos(theta) + z * Math.Sin(theta);
            double newY = y;
            double newZ = -x * Math.Sin(theta) + z * Math.Cos(theta);

            Vector3d result = new Vector3d(newX, newY, newZ);

            return result;
        }
        public static Vector3d rotateY(Vector3d vector, double angle)
        {
            return rotateY(vector.X, vector.Y, vector.Z, angle);
        }

        public static Vector3d rotateZ(double x, double y, double z, double angle)
        {
            double theta = angle * (Math.PI / 180);

            double newX = x * Math.Cos(theta) + y * Math.Sin(theta);
            double newY = -x * Math.Sin(theta) + y * Math.Cos(theta);
            double newZ = z;

            Vector3d result = new Vector3d(newX, newY, newZ);

            return result;
        }
        public static Vector3d rotateZ(Vector3d vector, double angle)
        {
            return rotateZ(vector.X, vector.Y, vector.Z, angle);
        }

        public static void FindIntersection(
            PointF p1, PointF p2, PointF p3, PointF p4,
            out bool lines_intersect, out bool segments_intersect,
            out PointF intersection,
            out PointF close_p1, out PointF close_p2)
        {
            // Get the segments' parameters.
            float dx12 = p2.X - p1.X;
            float dy12 = p2.Y - p1.Y;
            float dx34 = p4.X - p3.X;
            float dy34 = p4.Y - p3.Y;

            // Solve for t1 and t2
            float denominator = (dy12 * dx34 - dx12 * dy34);

            float t1 =
                ((p1.X - p3.X) * dy34 + (p3.Y - p1.Y) * dx34)
                    / denominator;
            if (float.IsInfinity(t1))
            {
                // The lines are parallel (or close enough to it).
                lines_intersect = false;
                segments_intersect = false;
                intersection = new PointF(float.NaN, float.NaN);
                close_p1 = new PointF(float.NaN, float.NaN);
                close_p2 = new PointF(float.NaN, float.NaN);
                return;
            }
            lines_intersect = true;

            float t2 =
                ((p3.X - p1.X) * dy12 + (p1.Y - p3.Y) * dx12)
                    / -denominator;

            // Find the point of intersection.
            intersection = new PointF(p1.X + dx12 * t1, p1.Y + dy12 * t1);

            // The segments intersect if t1 and t2 are between 0 and 1.
            segments_intersect =
                ((t1 >= 0) && (t1 <= 1) &&
                 (t2 >= 0) && (t2 <= 1));

            // Find the closest points on the segments.
            if (t1 < 0)
            {
                t1 = 0;
            }
            else if (t1 > 1)
            {
                t1 = 1;
            }

            if (t2 < 0)
            {
                t2 = 0;
            }
            else if (t2 > 1)
            {
                t2 = 1;
            }

            close_p1 = new PointF(p1.X + dx12 * t1, p1.Y + dy12 * t1);
            close_p2 = new PointF(p3.X + dx34 * t2, p3.Y + dy34 * t2);
        }
        public Point rotate(Point p1, Point center, float angle)
        {
            double ang = Math.PI * angle / 180;
            double x = ((p1.X - center.X) * Math.Cos(ang)) - ((p1.Y - center.Y) * Math.Sin(ang)) + center.X;
            double y = ((p1.X - center.X) * Math.Sin(ang)) + ((p1.Y - center.Y) * Math.Cos(ang)) + center.Y;

            Point result = new Point((int)x, (int)y);
            return result;
        }
        public float getAngleFromPercent(float percent)
        {
            float result = Map(percent, -100, 100, -45, 45);
            return result;
        }
        public float Map(float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        private void btn_InvLeft_Click(object sender, EventArgs e)
        {
            invertLeftPos = !invertLeftPos;
        }

        private void btn_InvRight_Click(object sender, EventArgs e)
        {
            invertRightPos = !invertRightPos;
        }
    }
}
