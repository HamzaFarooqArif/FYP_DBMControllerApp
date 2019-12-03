using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ColorMine.ColorSpaces;
using System.Configuration;
using System.Drawing;

namespace DBMControllerApp_TK.Utilities
{
    class CentralClass
    {
        public static CentralClass instance;

        public Hsv upper1;
        public Hsv lower1;
        public Hsv upper2;
        public Hsv lower2;

        public Point tipOffset;
        public bool showTipOffset;
        public bool showDemo3d;

        public int boardWidth;
        public int boardHeight;
        public bool showBoard;
        public static CentralClass getInstance()
        {
            if(instance == null)
            {
                instance = new CentralClass();
            }
            return instance;
        }

        public CentralClass()
        {
            boardWidth = 480;
            boardHeight = 320;
            showBoard = false;
            showTipOffset = false;
            showDemo3d = false;
            upper1 = new Hsv();
            lower1 = new Hsv();
            upper2 = new Hsv();
            lower2 = new Hsv();
            tipOffset = new Point(0, 0);

            upper1.H = Properties.Settings.Default.upper1H;
            upper1.S = Properties.Settings.Default.upper1S;
            upper1.V = Properties.Settings.Default.upper1V;

            lower1.H = Properties.Settings.Default.lower1H;
            lower1.S = Properties.Settings.Default.lower1S;
            lower1.V = Properties.Settings.Default.lower1V;

            upper2.H = Properties.Settings.Default.upper2H;
            upper2.S = Properties.Settings.Default.upper2S;
            upper2.V = Properties.Settings.Default.upper2V;

            lower2.H = Properties.Settings.Default.lower2H;
            lower2.S = Properties.Settings.Default.lower2S;
            lower2.V = Properties.Settings.Default.lower2V;
        }
    }
}
