using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;

namespace DBMControllerApp_TK.Utilities
{
    class MouseUtility
    {
        private static List<MouseUtility> _instance;
        public int pointLimit;
        public Point currentPoint;
        public Point[] points { get; set; }
        public int idx { get; set; }
        public float position;
        private MouseUtility()
        {
            pointLimit = 3;
            points = new Point[pointLimit];
            idx = 0;
            currentPoint = new Point();
            position = 0;
            //insertPoint(100, 100);
            //insertPoint(200, 100);
            //insertPoint(150, 50);
        }
        public static MouseUtility getInstance(int idx)
        {
            if (_instance == null)
            {
                _instance = new List<MouseUtility>();
                MouseUtility mouseUtility = new MouseUtility();
                _instance.Add(mouseUtility);
            }
            if(_instance.Count == idx)
            {
                MouseUtility mouseUtility = new MouseUtility();
                _instance.Add(mouseUtility);
            }
            return _instance[idx];
        }

        public bool insertPoint(int x, int y)
        {
            if(idx < pointLimit)
            {
                this.points[this.idx] = new Point(x, y);
                this.idx++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insertPoint(Point p)
        {
            return insertPoint(p.X, p.Y);
        }



        public List<Point> getEndPoints(int rows, int cols, Point p1, Point p2)
        {
            Point p = new Point(-1, -1);
            Point q = new Point(-1, -1);

            Point r1 = doIntercept(0, rows, cols, p1, p2);
            Point r2 = doIntercept(1, rows, cols, p1, p2);
            Point r3 = doIntercept(2, rows, cols, p1, p2);
            Point r4 = doIntercept(3, rows, cols, p1, p2);

            if(isValidPoint(r1, rows, cols))
            {
                setPoint(ref p, ref q, r1.X, r1.Y);
            }
            if (isValidPoint(r2, rows, cols))
            {
                setPoint(ref p, ref q, r2.X, r2.Y);
            }
            if (isValidPoint(r3, rows, cols))
            {
                setPoint(ref p, ref q, r3.X, r3.Y);
            }
            if (isValidPoint(r4, rows, cols))
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
                if(double.IsInfinity(m1))
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
                double y = m1*(cols) + c1;
                
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
                if(double.IsInfinity(m1))
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

        public bool isAssigned(Point p)
        {
            return p.X != -1 && p.Y != -1;
        }
        public bool isValidPoint(Point p, int rows, int cols)
        {
            if (p.X <= cols && p.X >= 0 && p.Y <= rows && p.Y >= 0)
            {
                return true;
            }
            return false;
        }

        public void setPoint(ref Point p, ref Point q, int x, int y)
        {
            if(!isAssigned(p))
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

        public List<Point> getPerpEndPoints(int rows, int cols, Point p1, Point p2, Point p3)
        {
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
            
            return getEndPoints(rows, cols, p3, p4);
        }

        public List<Point> getDistPoints(int rows, int cols, Point p1, Point p2, Point p3)
        {
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

        public int directionOfPoint(Point A, Point B, Point P)
        {
            // subtracting co-ordinates of point A from 
            // B and P, to make A as origin 
            B.X -= A.X;
            B.Y -= A.Y;
            P.X -= A.X;
            P.Y -= A.Y;

            // Determining cross Product 
            int cross_product = B.X * P.Y - B.Y * P.X;

            // return RIGHT if cross product is positive 
            if (cross_product > 0)
                return 1;   

            // return LEFT if cross product is negative 
            if (cross_product < 0)
                return -1;

            // return ZERO if cross product is zero.  
            return 0;
        }

        public Point rotate(Point p1, Point center, float angle)
        {
            double ang = Math.PI * angle / 180;
            double x = ((p1.X - center.X) * Math.Cos(ang)) - ((p1.Y - center.Y) * Math.Sin(ang)) + center.X;
            double y = ((p1.X - center.X) * Math.Sin(ang)) + ((p1.Y - center.Y) * Math.Cos(ang)) + center.Y;

            Point result = new Point((int)x, (int)y);
            return result;
        }
        public Point rotateRev(Point p1, Point center, float angle)
        {
            double ang = Math.PI * angle / 180;
            double y = ((p1.X - center.X) * Math.Cos(ang)) - ((p1.Y - center.Y) * Math.Sin(ang)) + center.X;
            double x = ((p1.X - center.X) * Math.Sin(ang)) + ((p1.Y - center.Y) * Math.Cos(ang)) + center.Y;

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

        public static double simplifyAngle(double angle)
        {
            if (angle >= 360) return angle - 360;
            if (angle <= -360) return angle + 360;
            if (angle <= 0) return angle + 360;
            return angle;
        }

        public static double Map(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
        public static double MapAngleToPoint(double angle, int paramLength)
        {
            double result = 0;

            if (0 <= angle && angle <= 90)
            {
                result = (int)MouseUtility.Map(angle, 0, 90, 0, paramLength / 2);
            }
            else if(90 < angle && angle <= 180)
            {
                result = (int)MouseUtility.Map(angle, 90, 180, paramLength / 2, 0);
            }
            else if (180 < angle && angle <= 270)
            {
                result = (int)MouseUtility.Map(angle, 180, 270, 0, -(paramLength / 2));
            }
            else if (270 < angle && angle <= 360)
            {
                result = (int)MouseUtility.Map(angle, 270, 360, -(paramLength / 2), 0);
            }

            return result;
        }

        public static Point getRotatedPointZ(int x, int y, double angle)
        {
            int rX = (int)(x * Math.Cos((Math.PI / 180) * angle)) + (int)(y * Math.Sin((Math.PI / 180) * angle));
            int rY = (int)(-x * Math.Sin((Math.PI / 180) * angle)) + (int)(y * Math.Cos((Math.PI / 180) * angle));

            return new Point(rX, rY);
        }

        public static Point getRotatedPointY(int x, int y, double angle)
        {
            int rX = (int)(x * Math.Cos((Math.PI / 180) * angle));
            int rY = y;

            return new Point(rX, rY);
        }

        public static Point getRotatedPointX(int x, int y, double angle)
        {
            int rX = x;
            int rY = (int)(y * Math.Cos((Math.PI / 180) * angle));

            return new Point(rX, rY);
        }

        public static Tuple<double ,double ,double> getActualEuler(double coordX, double coordY, double coordZ, double xRot, double yRot, double zRot)
        {
            double resultX;
            double resultY;
            double resultZ;

            double xRotRadian = coordX * (Math.PI / 180);
            double yRotRadian = coordY * (Math.PI / 180);
            double zRotRadian = coordZ * (Math.PI / 180);

            //X-Rotation
            resultX = xRot;
            resultY = yRot * Math.Cos(xRotRadian) - zRot * Math.Sin(xRotRadian);
            resultZ = yRot * Math.Sin(xRotRadian) + zRot * Math.Cos(xRotRadian);

            //Y-Rotation
            resultX = resultX * Math.Cos(yRotRadian) + resultZ * Math.Sin(yRotRadian);
            resultY = resultY;
            resultZ = -resultX * Math.Sin(yRotRadian) + resultZ * Math.Cos(yRotRadian);

            //Z-Rotation
            resultX = resultX * Math.Cos(zRotRadian) + resultY * Math.Sin(zRotRadian);
            resultY = -resultX * Math.Sin(zRotRadian) + resultY * Math.Cos(zRotRadian);
            resultZ = resultZ;

            Tuple<double, double, double> result = new Tuple<double, double, double>(resultX, resultY, resultZ);
            return result;
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

        public static Vector3 ToEulerAngles(Quaternion q)
        {
            // Store the Euler angles in radians
            Vector3 pitchYawRoll = new Vector3();

            double sqw = q.W * q.W;
            double sqx = q.X * q.X;
            double sqy = q.Y * q.Y;
            double sqz = q.Z * q.Z;

            // If quaternion is normalised the unit is one, otherwise it is the correction factor
            double unit = sqx + sqy + sqz + sqw;
            double test = q.X * q.Y + q.Z * q.W;

            if (test > 0.4999f * unit)                              // 0.4999f OR 0.5f - EPSILON
            {
                // Singularity at north pole
                pitchYawRoll.Y = 2f * (float)Math.Atan2(q.X, q.W);  // Yaw
                pitchYawRoll.X = (float)Math.PI * 0.5f;                         // Pitch
                pitchYawRoll.Z = 0f;                                // Roll
                return pitchYawRoll;
            }
            else if (test < -0.4999f * unit)                        // -0.4999f OR -0.5f + EPSILON
            {
                // Singularity at south pole
                pitchYawRoll.Y = -2f * (float)Math.Atan2(q.X, q.W); // Yaw
                pitchYawRoll.X = -(float)Math.PI * 0.5f;                        // Pitch
                pitchYawRoll.Z = 0f;                                // Roll
                return pitchYawRoll;
            }
            else
            {
                pitchYawRoll.Y = (float)Math.Atan2(2f * q.Y * q.W - 2f * q.X * q.Z, sqx - sqy - sqz + sqw);       // Yaw
                pitchYawRoll.X = (float)Math.Asin(2f * test / unit);                                             // Pitch
                pitchYawRoll.Z = (float)Math.Atan2(2f * q.X * q.W - 2f * q.Y * q.Z, -sqx + sqy - sqz + sqw);      // Roll
            }

            pitchYawRoll.X *= (float)(180 / Math.PI);
            pitchYawRoll.Y *= (float)(180 / Math.PI);
            pitchYawRoll.Z *= (float)(180 / Math.PI);

            pitchYawRoll.X = (float)simplifyAngle(pitchYawRoll.X);
            pitchYawRoll.Y = (float)simplifyAngle(pitchYawRoll.Y);
            pitchYawRoll.Z = (float)simplifyAngle(pitchYawRoll.Z);

            return pitchYawRoll;
        }

        public static Point findIntercept(Point l1p1, Point l1p2, Point l2p1, Point l2p2)
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
    }
}
