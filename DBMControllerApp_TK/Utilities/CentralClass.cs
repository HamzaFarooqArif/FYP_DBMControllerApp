using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ColorMine.ColorSpaces;
using System.Configuration;

namespace DBMControllerApp_TK.Utilities
{
    class CentralClass
    {
        public static CentralClass instance;
        public Hsv upper1;
        public Hsv lower1;
        public Hsv upper2;
        public Hsv lower2;

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
            upper1 = new Hsv();
            lower1 = new Hsv();
            upper2 = new Hsv();
            lower2 = new Hsv();

            upper1.H = Convert.ToDouble(ConfigurationManager.AppSettings["upper1H"]);
            upper1.S = Convert.ToDouble(ConfigurationManager.AppSettings["upper1S"]);
            upper1.V = Convert.ToDouble(ConfigurationManager.AppSettings["upper1V"]);

            lower1.H = Convert.ToDouble(ConfigurationManager.AppSettings["lower1H"]);
            lower1.S = Convert.ToDouble(ConfigurationManager.AppSettings["lower1S"]);
            lower1.V = Convert.ToDouble(ConfigurationManager.AppSettings["lower1V"]);

            upper2.H = Convert.ToDouble(ConfigurationManager.AppSettings["upper2H"]);
            upper2.S = Convert.ToDouble(ConfigurationManager.AppSettings["upper2S"]);
            upper2.V = Convert.ToDouble(ConfigurationManager.AppSettings["upper2V"]);

            lower2.H = Convert.ToDouble(ConfigurationManager.AppSettings["lower2H"]);
            lower2.S = Convert.ToDouble(ConfigurationManager.AppSettings["lower2S"]);
            lower2.V = Convert.ToDouble(ConfigurationManager.AppSettings["lower2V"]);

        }
    }
}
