using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DirectShowLib;

namespace DBMControllerApp_TK.Utilities
{
    class Utility
    {
        public static List<string> getCameraList()
        {
            return DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice).Select(v => v.Name).ToList();
        }
    }
}
