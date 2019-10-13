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
using ColorMine;

namespace DBMControllerApp_TK
{
    public partial class Form1 : Form
    {
        private static Form1 instance;

        public static VideoCapture capture0;
        public static VideoCapture capture1;

        public static Form1 getInstance()
        {
            if(instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }
        private Form1()
        {
            InitializeComponent();

            cb_camList1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_camList2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_camList1.DataSource = getCameraList();
            cb_camList2.DataSource = getCameraList();


        }
        
        private void btn_Capture1_Click(object sender, EventArgs e)
        {
            if(cb_camList2.Enabled == false && cb_camList1.SelectedIndex == cb_camList2.SelectedIndex)
            {
                MessageBox.Show("Selected capture device is busy");
            }
            else if(cb_camList1.Items.Count > 0)
            {
                capture0 = new VideoCapture(cb_camList1.SelectedIndex);
                capture0.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, Int32.Parse(tb_fps1.Text));
                capture0.ImageGrabbed += Cam1_Preview.getInstance().processFrame;
                capture0.Start();
                cb_camList1.Enabled = false;
                tb_fps1.Enabled = false;
                btn_Capture1.Enabled = false;
                //Cam1_Preview.getInstance().Show();
            }
            else
            {
                MessageBox.Show("Select a valid capture device");
            }
        }

        private List<string> getCameraList()
        {
            return DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice).Select(v => v.Name).ToList();
        }

        private void btn_Capture2_Click(object sender, EventArgs e)
        {
            if (cb_camList1.Enabled == false && cb_camList1.SelectedIndex == cb_camList2.SelectedIndex)
            {
                MessageBox.Show("Selected capture device is busy");
            }
            else if (cb_camList2.Items.Count > 0)
            {
                capture1 = new VideoCapture(cb_camList2.SelectedIndex);
                capture1.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, Int32.Parse(tb_fps2.Text));
                capture1.ImageGrabbed += Cam2_Preview.getInstance().processFrame;
                capture1.Start();
                cb_camList2.Enabled = false;
                tb_fps2.Enabled = false;
                btn_Capture2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select a valid capture device");
            }
        }

        private void tbn_preview1_Click(object sender, EventArgs e)
        {
            if(cb_camList1.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            if(Cam1_Preview.getInstance().Visible)
            {
                Cam1_Preview.getInstance().Hide();
            }
            else
            {
                Cam1_Preview.getInstance().Show();
            }
        }

        private void btn_preview2_Click(object sender, EventArgs e)
        {
            if (cb_camList2.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            if (Cam2_Preview.getInstance().Visible)
            {
                Cam2_Preview.getInstance().Hide();
            }
            else
            {
                Cam2_Preview.getInstance().Show();
            }
        }

        private void btn_filter1_Click(object sender, EventArgs e)
        {
            if (cb_camList1.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            if (Cam_FilterProp.getInstance(0).Visible)
            {
                Cam_FilterProp.getInstance(0).Hide();
            }
            else
            {
                Cam_FilterProp.getInstance(0).Show();
            }
        }

        private void btn_filter2_Click(object sender, EventArgs e)
        {
            if (cb_camList2.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            if (Cam_FilterProp.getInstance(1).Visible)
            {
                Cam_FilterProp.getInstance(1).Hide();
            }
            else
            {
                Cam_FilterProp.getInstance(1).Show();
            }
        }
    }
}
