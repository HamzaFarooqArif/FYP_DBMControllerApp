using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMControllerApp_TK.Utilities
{
    class jsonObj
    {
        public int x;
        public int y;
        public double time;
        public int thickness;
        public Color color;
        public int isTipDown;

        public jsonObj(int x, int y, double time, int thickness, Color color, int isTipDown)
        {
            this.x = x;
            this.y = y;
            this.time = time;
            this.thickness = thickness;
            this.color = color;
            this.isTipDown = isTipDown;
        }
    }
    class Animation
    {
        public static List<jsonObj> objList;
        public static int width;
        public static int height;
        public static int tickResolution;
        public static List<Mat> videoFrames;
        public static bool loadFromFile(string fullPath)
        {
            if (!File.Exists(fullPath)) return false;
            objList = new List<jsonObj>();
            string json;
            using (StreamReader r = new StreamReader(fullPath))
            {
                json = r.ReadToEnd();
                objList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<jsonObj>>(json);
                if (objList == null) objList = new List<jsonObj>();
                else
                {
                    width = objList[objList.Count - 1].x;
                    height = objList[objList.Count - 1].y;
                    tickResolution = (int)objList[objList.Count - 1].time;
                    objList.Remove(objList[objList.Count - 1]);
                }
            }
            return true;
        }
        public static bool saveToFile(string fullPath, int width, int height, int tickResolution)
        {
            if (!File.Exists(fullPath))
            {
                File.Create(fullPath).Close();
            }
            if (objList == null) objList = new List<jsonObj>();
            jsonObj configObj = new jsonObj(width, height, tickResolution, 0, Color.FromArgb(0, 0, 0), 0);
            objList.Add(configObj);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objList.ToArray());
            System.IO.File.WriteAllText(fullPath, json);
            objList.Remove(objList[objList.Count - 1]);
            return true;
        }
        public static void appendObj(int x, int y, double time, int thickness, Color color, int isTipDown)
        {
            jsonObj obj = new jsonObj(x, y, time, thickness, color, isTipDown);
            objList.Add(obj);
        }
        public static void appendObj(Point p, double time, int thickness, Color color, int isTipDown)
        {
            appendObj(p.X, p.Y, time, thickness, color, isTipDown);
        }
        public static void prepareVideo()
        {
            if (objList == null) objList = new List<jsonObj>();
            if (videoFrames == null) videoFrames = new List<Mat>();
            videoFrames.Clear();
            Point currentPoint = new Point();
            Point prevPoint = new Point();
            int isTipDown = 0;
            Mat frame = new Image<Bgr, byte>(width, height).Mat;
            foreach (jsonObj obj in objList)
            {
                currentPoint = new Point(obj.x, obj.y);
                if(isTipDown == 1)
                {
                    CvInvoke.Line(frame, prevPoint, currentPoint, new MCvScalar(obj.color.B, obj.color.G, obj.color.R), (obj.thickness * height) / 100);
                }
                else if(isTipDown == 0)
                {
                    CvInvoke.Line(frame, currentPoint, currentPoint, new MCvScalar(obj.color.B, obj.color.G, obj.color.R), (obj.thickness * height) / 100);
                }
                videoFrames.Add(frame.Clone());
                isTipDown = obj.isTipDown;
                prevPoint = currentPoint;
            }
        }
        //public static bool drawOnFrame(ref Mat frame, int idx)
        //{
        //    if (videoFrames == null || videoFrames.Count - 1 < idx) return false;
        //    frame = videoFrames[idx];
        //    CvInvoke.Imshow("temp", frame);
        //    return true;
        //}
        
    }
}
