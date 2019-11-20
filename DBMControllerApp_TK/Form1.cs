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
using System.Configuration;
using DBMControllerApp_TK.Utilities;

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

            Application.Idle += idleEvent;
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
            if (cb_camList1.Enabled == true)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(capture0 != null) capture0.Dispose();
            if (capture1 != null) capture1.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            AddOrUpdateAppSettings("upper1H", "123");

            //ConfigurationManager.AppSettings.Remove("upper1H");
            //ConfigurationManager.AppSettings.Add("upper1H", CentralClass.getInstance().upper1.H.ToString());
            
            MessageBox.Show(ConfigurationManager.AppSettings["upper1H"]); 
        }

        public void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            int boardWidth = CentralClass.getInstance().boardWidth;
            int boardHeight = CentralClass.getInstance().boardHeight;
            
            Image<Gray, byte> boardFrame = new Image<Gray, byte>(boardWidth, boardHeight);
            Point line1p1 = new Point((int)((float)boardWidth * (float)0.1), (int)((float)boardHeight * (float)0.1));
            Point line1p2 = new Point(boardWidth, boardHeight);
            Point line2p1 = new Point((int)((float)boardWidth * (float)0.9), (int)((float)boardHeight * (float)0.1));
            Point line2p2 = new Point(0, boardHeight);

            line1p2 = MouseUtility.getInstance(0).rotate(line1p2, line1p1, (float)11.5 - MouseUtility.getInstance(0).getAngleFromPercent(MouseUtility.getInstance(0).position));
            line2p2 = MouseUtility.getInstance(1).rotate(line2p2, line2p1, (float)-11.5 + MouseUtility.getInstance(1).getAngleFromPercent(MouseUtility.getInstance(1).position));

            CvInvoke.Circle(boardFrame, line1p1, 1, new MCvScalar(255, 255, 255), 2);
            CvInvoke.Circle(boardFrame, line1p2, 1, new MCvScalar(255, 255, 255), 2);
            CvInvoke.Circle(boardFrame, line2p1, 1, new MCvScalar(255, 255, 255), 2);
            CvInvoke.Circle(boardFrame, line2p2, 1, new MCvScalar(255, 255, 255), 2);
            CvInvoke.Line(boardFrame, line1p1, line1p2, new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, line2p1, line2p2, new MCvScalar(255, 255, 255));

            if (CentralClass.getInstance().showBoard)
            {
                CvInvoke.Imshow("Board", boardFrame);
            }
            else
            {
                CvInvoke.DestroyWindow("Board");
            }
        }

        private void btn_Board_Click(object sender, EventArgs e)
        {
            CentralClass.getInstance().showBoard = !CentralClass.getInstance().showBoard;
        }

        private void btn_orientation_Click(object sender, EventArgs e)
        {
            if(OrientationForm.getInstance().Visible)
            {
                OrientationForm.getInstance().Hide();
            }
            else
            {
                OrientationForm.getInstance().Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
