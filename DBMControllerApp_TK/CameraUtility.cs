using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DirectShowLib;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DBMControllerApp_TK
{
    class CameraUtility
    {
        public static List<CameraUtility> _instances;
        public bool isPreview = false;
        public VideoCapture capture;
        public int idx;
        public static CameraUtility getInstance(int idx)
        {
            if(_instances == null)
            {
                _instances = new List<CameraUtility>();
            }
            while(_instances.Count < idx + 1 )
            {
                CameraUtility item = new CameraUtility(idx);
                _instances.Add(item);
            }
            return _instances[idx];
        }
        
        public CameraUtility(int idx)
        {
            bool duplicateExists = false;
            foreach(CameraUtility cu in _instances)
            {
                if(cu.idx == idx)
                {
                    capture = cu.capture;
                    duplicateExists = true;
                    this.idx = _instances.Count;
                    break;
                }
            }
            if(!duplicateExists)
            {
                capture = new VideoCapture(idx);
                this.idx = idx;
            }
            
        }
        public List<string> getCameraList()
        {
             return DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice).Select(v => v.Name).ToList();
        }

        public void processFrame()
        {
            Image<Bgr, Byte> frameOriginal = this.capture.QueryFrame().ToImage<Bgr, Byte>();
            if (isPreview)
            {
                CvInvoke.Imshow("Frame " + this.idx, frameOriginal);
            }
            else
            {
                CvInvoke.DestroyWindow("Frame " + this.idx);
            }

        }
    }
}
