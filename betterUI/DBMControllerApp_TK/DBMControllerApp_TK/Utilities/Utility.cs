using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DirectShowLib;
using OpenTK;

namespace DBMControllerApp_TK.Utilities
{
    class Utility
    {
        public static int boardWidth = 480;
        public static int boardHeight = 320;

        public static List<string> errorList = new List<string>(new string[] {
            "Select a valid capture device",
            "Start the capture device first",
            "Are you sure you want to close the application?",
            "Please select a valid COM port",
            "Settings Saved Successfully",
            "Load a lecture file first"
        });
        public static List<string> getCameraList()
        {
            return DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice).Select(v => v.Name).ToList();
        }

        static void threeaxisrot(double r11, double r12, double r21, double r31, double r32, double[] res)
        {
            res[0] = Math.Atan2(r31, r32);
            res[1] = Math.Asin(r21);
            res[2] = Math.Atan2(r11, r12);
        }
        static double rad2deg(double rad)
        {
            return rad * 180.0 / Math.PI;
        }
        public static Vector3 ToEulerAngles(Quaternion q)
        {
            double[] res = { 1, 1, 1 };
            threeaxisrot(-2 * (q.Y * q.Z - q.W * q.X),
                    q.W * q.W - q.X * q.X - q.Y * q.Y + q.Z * q.Z,
                    2 * (q.X * q.Z + q.W * q.Y),
                   -2 * (q.X * q.Y - q.W * q.Z),
                    q.W * q.W + q.X * q.X - q.Y * q.Y - q.Z * q.Z,
                    res);
            Vector3 result = new Vector3((float)(rad2deg(res[0])), (float)(rad2deg(res[1])), (float)(rad2deg(res[2])));
            return result;
        }
        public static double simplifyAngle(double angle)
        {
            if (angle >= 360) return angle - 360;
            if (angle <= -360) return angle + 360;
            if (angle <= 0) return angle + 360;
            return angle;
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
        public static Vector3d rotateX(Vector3d vector, double angle)
        {
            return rotateX(vector.X, vector.Y, vector.Z, angle);
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

        public static Tuple<Point, Point> drawVector(Vector3d vector, int oX, int oY)
        {
            Point origin = new Point(oX, oY);
            Point point = new Point((int)(vector.X + oX), (int)(-vector.Y + oY));
            return new Tuple<Point, Point>(origin, point);
        }

    }
}
