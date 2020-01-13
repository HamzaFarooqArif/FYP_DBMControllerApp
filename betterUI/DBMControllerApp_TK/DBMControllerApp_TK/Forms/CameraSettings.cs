using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;
using DBMControllerApp_TK.Utilities;
using Emgu.CV.UI;

namespace DBMControllerApp_TK.Forms
{
    public partial class CameraSettings : Form
    {
        private static List<CameraSettings> _instance;
        public int formIdx;
        private int camIdx;
        private VideoCapture capture;
        private int fps;
        public Mat frame;
        private bool deviceBusy;
        private bool isPreview;
        public static CameraSettings getInstance(int idx)
        {
            if(_instance == null)
            {
                _instance = new List<CameraSettings>();
            }
            while(_instance.Count - 1 < idx)
            {
                _instance.Add(new CameraSettings());
            }
            return _instance[idx];
        }
        private CameraSettings()
        {
            InitializeComponent();
            formIdx = _instance.Count;
            camIdx = -1;
            lbl_CameraIndex.Text = lbl_CameraIndex.Text + " " + (formIdx + 1);
            cb_camList.DropDownStyle = ComboBoxStyle.DropDownList;
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            cb_camList.DataSource = Utility.getCameraList();
            tb_fps.Value = 30;
            fps = 0;
            isPreview = false;
            deviceBusy = false;
        }

        private void CameraSettings_Load(object sender, EventArgs e)
        {

        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {

        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            if(cb_camList.Enabled)
            {
                cb_camList.Enabled = false;
                tb_fps.Enabled = false;
                btn_Capture.Text = "Stop Capture";
                camIdx = cb_camList.SelectedIndex;
                fps = (int)tb_fps.Value;
                deviceBusy = true;
                frame = new Mat();
                foreach (CameraSettings form in _instance)
                {
                    if(form.formIdx != this.formIdx && form.camIdx != this.camIdx)
                    {
                        capture = new VideoCapture(cb_camList.SelectedIndex);
                        capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, (int)tb_fps.Value);
                        capture.ImageGrabbed += processFrame;
                        capture.Start();
                        deviceBusy = false;
                    }
                }
                
            }
            else
            {
                if(!deviceBusy)
                {
                    capture.Stop();
                    capture.Dispose();
                    capture = null;
                    foreach (CameraSettings form in _instance)
                    {
                        if (form.formIdx != this.formIdx && form.deviceBusy && form.camIdx == this.camIdx && form.capture == null)
                        {
                            form.stopAll();
                        }
                    }
                }
                stopAll();
            }
        }

        public void stopAll()
        {
            isPreview = false;
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            btn_Preview.Text = "Preview";
            frame = null;
            camIdx = -1;
            cb_camList.Enabled = true;
            tb_fps.Enabled = true;
            btn_Capture.Text = "Capture";
            fps = 0;
            deviceBusy = false;
        }
        public void processFrame(object sender, EventArgs arg)
        {
            capture.Retrieve(frame, 0);
            if(isPreview) ib_Preview.Image = frame;
            foreach(CameraSettings form in _instance)
            {
                if(form.formIdx != this.formIdx && form.deviceBusy && form.camIdx == this.camIdx && form.capture == null)
                {
                    form.setImage(frame);
                }
            }
        }

        public void setImage(Mat img)
        {
            frame = img;
            if(isPreview) ib_Preview.Image = frame;
        }

        private void btn_Preview_Click_1(object sender, EventArgs e)
        {
            if(isPreview)
            {
                isPreview = false;
                ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
                ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
                btn_Preview.Text = "Preview";
            }
            else if(frame != null)
            {
                isPreview = true;
                ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
                btn_Preview.Text = "Hide Preview";
            }
        }
    }
}
