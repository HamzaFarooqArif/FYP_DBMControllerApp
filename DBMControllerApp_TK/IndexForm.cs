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
using System.Threading;
using OpenTK;

namespace DBMControllerApp_TK
{
    public partial class IndexForm : Form
    {
        private static IndexForm instance;

        public static VideoCapture capture0;
        public static VideoCapture capture1;

        public static IndexForm getInstance()
        {
            if(instance == null)
            {
                instance = new IndexForm();
            }
            return instance;
        }
        private IndexForm()
        {
            InitializeComponent();

            cb_camList1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_camList2.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_camList1.DataSource = getCameraList();
            cb_camList2.DataSource = getCameraList();

            tb_fps1.Text = Properties.Settings.Default.Cam1FPS.ToString();
            tb_fps2.Text = Properties.Settings.Default.Cam2FPS.ToString();

            Application.Idle += idleEvent;

            initiateAllForms();
        }
        private void initiateAllForms()
        {
            Cam1_Preview.getInstance().Hide();
            Cam2_Preview.getInstance().Hide();
            Cam_FilterProp.getInstance(0).Hide();
            Cam_FilterProp.getInstance(1).Hide();
            OrientationForm.getInstance().Hide();
            DrawingBoard.getInstance().Hide();
            PositionSettings.getInstance().Hide();
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
            Cam1_Preview.getInstance().Show();
        }

        private void btn_preview2_Click(object sender, EventArgs e)
        {
            if (cb_camList2.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            Cam2_Preview.getInstance().Show();
        }

        private void btn_filter1_Click(object sender, EventArgs e)
        {
            if (cb_camList1.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            Cam_FilterProp.getInstance(0).Show();
        }

        private void btn_filter2_Click(object sender, EventArgs e)
        {
            if (cb_camList2.Enabled == true)
            {
                MessageBox.Show("Start the capture device first");
                return;
            }
            Cam_FilterProp.getInstance(1).Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(capture0 != null) capture0.Dispose();
            if (capture1 != null) capture1.Dispose();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to save settings?", "Save Settings", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.Cam1FPS = Int32.Parse(tb_fps1.Text);
                Properties.Settings.Default.Cam2FPS = Int32.Parse(tb_fps2.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings Saved");
            }
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
            //drawBoard();
            //drawOrientationPlane();
        }

        private void btn_Board_Click(object sender, EventArgs e)
        {
            PositionSettings.getInstance().Show();
            //CentralClass.getInstance().showBoard = !CentralClass.getInstance().showBoard;
        }

        private void btn_orientation_Click(object sender, EventArgs e)
        {
            OrientationForm.getInstance().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //private void drawBoard()
        //{
        //    int boardWidth = CentralClass.getInstance().boardWidth;
        //    int boardHeight = CentralClass.getInstance().boardHeight;
        //    float sizeFactor = 0.5f;

        //    Image<Bgr, byte> boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);
        //    Point line1p1 = new Point((int)((float)boardWidth * (float)0.1), (int)((float)boardHeight * (float)0.1));
        //    Point line1p2 = new Point(boardWidth, boardHeight);
        //    Point line2p1 = new Point((int)((float)boardWidth * (float)0.9), (int)((float)boardHeight * (float)0.1));
        //    Point line2p2 = new Point(0, boardHeight);

        //    line1p2 = MouseUtility.getInstance(0).rotate(line1p2, line1p1, (float)11.5 - MouseUtility.getInstance(0).getAngleFromPercent(MouseUtility.getInstance(0).position));
        //    line2p2 = MouseUtility.getInstance(1).rotate(line2p2, line2p1, (float)-11.5 + MouseUtility.getInstance(1).getAngleFromPercent(MouseUtility.getInstance(1).position));

        //    //line1p2 = MouseUtility.getInstance(0).getEndPoints(boardHeight, boardWidth, line1p1, line1p2)[1];
        //    //line2p2 = MouseUtility.getInstance(1).getEndPoints(boardHeight, boardWidth, line2p1, line2p2)[1];

        //    CvInvoke.Circle(boardFrame, line1p1, 5, new MCvScalar(255, 0, 0), 2);
        //    CvInvoke.Circle(boardFrame, line1p2, 5, new MCvScalar(255, 0, 0), 2);
        //    CvInvoke.Circle(boardFrame, line2p1, 5, new MCvScalar(255, 0, 0), 2);
        //    CvInvoke.Circle(boardFrame, line2p2, 5, new MCvScalar(255, 0, 0), 2);
        //    CvInvoke.Line(boardFrame, line1p1, line1p2, new MCvScalar(255, 255, 255));
        //    CvInvoke.Line(boardFrame, line2p1, line2p2, new MCvScalar(255, 255, 255));

        //    //CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), 5, new MCvScalar(255, 255, 255), 5);

        //    PointF notNeedp1 = new PointF();
        //    PointF notNeedp2 = new PointF();
        //    PointF p3 = new PointF();
        //    bool notNeeda;
        //    bool notNeedb;
        //    MouseUtility.FindIntersection(line1p1, line1p2, line2p1, line2p2, out notNeeda, out notNeedb, out p3, out notNeedp1, out notNeedp2);
        //    Point position = new Point((int)p3.X, (int)p3.Y);

        //    CvInvoke.Circle(boardFrame, position, 5, new MCvScalar(255, 0, 0), 2);


        //    double calibX = MouseUtility.simplifyAngle(demo3d.calibX);
        //    double calibY = MouseUtility.simplifyAngle(demo3d.calibY);
        //    double calibZ = MouseUtility.simplifyAngle(demo3d.calibZ);

        //    Vector3d markerVect = new Vector3d(0, 0, 100);

        //    markerVect = MouseUtility.rotateX(markerVect, calibX);
        //    markerVect = MouseUtility.rotateY(markerVect, calibY);
        //    //markerVect = MouseUtility.rotateZ(markerVect, calibZ);
        //    markerVect.X = markerVect.X * sizeFactor;
        //    markerVect.Y = markerVect.Y * sizeFactor;
        //    markerVect.Z = markerVect.Z * sizeFactor;

        //    Point actualPosition = new Point(MouseUtility.drawVector(markerVect, position.X, position.Y).Item2.X, MouseUtility.drawVector(markerVect, position.X, position.Y).Item2.Y);

        //    //CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
        //    //CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));
        //    CvInvoke.Line(boardFrame, position, actualPosition, new MCvScalar(0, 0, 255), 2);

            
        //    //if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(0, 0, 255), 1);
        //    //else CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(255, 0, 0), 1);

        //    if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(0, 0, 255), 1);
        //    else CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(255, 0, 0), 1);

        //    CentralClass.getInstance().tipOffset.X = (int)markerVect.X;
        //    CentralClass.getInstance().tipOffset.Y = (int)markerVect.Y;

        //    if (CentralClass.getInstance().showBoard)
        //    {
        //        CvInvoke.Imshow("Board", boardFrame);
        //    }
        //    else
        //    {
        //        CvInvoke.DestroyWindow("Board");
        //    }
        //}
        

        private void button1_Click(object sender, EventArgs e)
        {
            DrawingBoard.getInstance().Show();
        }
    }
}
