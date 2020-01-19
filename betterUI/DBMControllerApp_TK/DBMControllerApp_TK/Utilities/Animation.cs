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
            }
            return true;
        }
        public static bool saveToFile(string fullPath)
        {
            if (!File.Exists(fullPath)) return false;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objList.ToArray());
            System.IO.File.WriteAllText(fullPath, json);
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
        public static void flushAll(string fullPath)
        {
            objList = new List<jsonObj>();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objList.ToArray());
            System.IO.File.WriteAllText(fullPath, json);
        }
    }
}
