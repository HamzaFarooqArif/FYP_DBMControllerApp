using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMControllerApp_TK.Forms
{
    public partial class OrientationSettings : Form
    {
        private static OrientationSettings _instance;
        public int offsetX;
        public int offsetY;
        public int offsetZ;
        public bool showDemo3d;
        GameWindow window;
        public int OPWidth;
        public int OPHeight;
        public Point tipOffset;
        private bool showDemo2d;
        public double pressure;
        private delegate void SetTextDeleg(string text);
        public static OrientationSettings getInstance()
        {
            if (_instance == null)
            {
                _instance = new OrientationSettings();
            }
            return _instance;
        }
        public OrientationSettings()
        {
            InitializeComponent();
            showDemo3d = false;
            BindingSource ports = new BindingSource();
            ports.DataSource = SerialPort.GetPortNames().ToList();
            cb_SerialList.DataSource = ports;
            OPWidth = 480;
            OPHeight = 320;
            tipOffset = new Point();
            showDemo2d = false;
            loadSettings();

            Thread t1 = new Thread(demo);
            t1.Start();
            Application.Idle += idleEvent;
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            drawOrientationPlane();
        }
        void demo()
        {
            window = new GameWindow(500, 500);
            demo3d gm = new demo3d(window);
        }

        private void OrientationSettings_Load(object sender, EventArgs e)
        {

        }

        private void trk_OffX_ValueChanged(object sender, EventArgs e)
        {
            if(trk_OffX.Focused)
            {
                offsetX = trk_OffX.Value;
                tb_OffX.Value = offsetX;
            }
        }

        private void trk_OffY_ValueChanged(object sender, EventArgs e)
        {
            if (trk_OffY.Focused)
            {
                offsetY = trk_OffY.Value;
                tb_OffY.Value = offsetY;
            }
        }

        private void trk_OffZ_ValueChanged(object sender, EventArgs e)
        {
            if (trk_OffZ.Focused)
            {
                offsetZ = trk_OffZ.Value;
                tb_OffZ.Value = offsetZ;
            }
        }

        private void tb_OffX_ValueChanged(object sender, EventArgs e)
        {
            if (tb_OffX.Focused)
            {
                offsetX = (int)tb_OffX.Value;
                trk_OffX.Value = offsetX;
            }
        }

        private void tb_OffY_ValueChanged(object sender, EventArgs e)
        {
            if (tb_OffY.Focused)
            {
                offsetY = (int)tb_OffY.Value;
                trk_OffY.Value = offsetY;
            }
        }

        private void tb_OffZ_ValueChanged(object sender, EventArgs e)
        {
            if (tb_OffZ.Focused)
            {
                offsetZ = (int)tb_OffZ.Value;
                trk_OffZ.Value = offsetZ;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cb_SerialList.Text) && !serialPort.IsOpen)
            {
                serialPort.PortName = cb_SerialList.Text;
                serialPort.BaudRate = 115200;
                serialPort.Open();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(ProcessSerialFrame);
                btn_Start.Text = "Stop Serial";
                cb_SerialList.Enabled = false;
                btn_Refresh.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(cb_SerialList.Text) && serialPort.IsOpen)
            {
                serialPort.Close();
                btn_Start.Text = "Start Serial";
                cb_SerialList.Enabled = true;
                btn_Refresh.Enabled = true;
            }
            else
            {
                MessageBox.Show(Utility.errorList[3]);
            }
        }
        private void ProcessSerialFrame(object sender, EventArgs arg)
        {
            string x = serialPort.ReadLine();
            this.BeginInvoke(new SetTextDeleg(setPortText), new object[] { x });
        }
        private void setPortText(string text)
        {
            string[] data = text.Split('\t');


            if (data.Length == 5 && !data[1].Equals("nan") && !data[2].Equals("nan") && !data[3].Equals("nan") && !data[4].Equals("nan"))
            {
                tb_DataPacket.Text = text;

                double rotX = (-double.Parse(data[3], System.Globalization.CultureInfo.InvariantCulture));
                double rotY = (-double.Parse(data[2], System.Globalization.CultureInfo.InvariantCulture));
                double rotZ = -double.Parse(data[1], System.Globalization.CultureInfo.InvariantCulture);
                pressure = double.Parse(data[4], System.Globalization.CultureInfo.InvariantCulture);

                demo3d.zRot = rotZ;
                demo3d.xRot = rotX;
                demo3d.yRot = rotY;
                demo3d.pressure = pressure;

                tb_OrientX.Text = demo3d.calibX.ToString();
                tb_OrientY.Text = demo3d.calibY.ToString();
                tb_OrientZ.Text = demo3d.calibZ.ToString();
                tb_CurrentPressure.Text = demo3d.pressure.ToString();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_SerialList.Text = "";
            BindingSource ports = new BindingSource();
            ports.DataSource = SerialPort.GetPortNames().ToList();
            cb_SerialList.DataSource = ports;
        }

        private void btn_Show3d_Click(object sender, EventArgs e)
        {
            if (!showDemo3d) btn_Show3d.Text = "Hide 3d";
            else btn_Show3d.Text = "Show 3d Orientation";
            showDemo3d = !showDemo3d;
        }

        private void btn_Show2d_Click(object sender, EventArgs e)
        {
            if (!showDemo2d) btn_Show2d.Text = "Hide 2d";
            else btn_Show2d.Text = "Show 2d Orientation";
            showDemo2d = !showDemo2d;
        }
        private void drawOrientationPlane()
        {
            Image<Bgr, byte> boardFrame = new Image<Bgr, byte>(OPWidth, OPHeight);

            double calibX = Utility.simplifyAngle(demo3d.calibX);
            double calibY = Utility.simplifyAngle(demo3d.calibY);
            double calibZ = Utility.simplifyAngle(demo3d.calibZ);

            Vector3d markerVect = new Vector3d(0, 0, 100);

            markerVect = Utility.rotateX(markerVect, calibX);
            markerVect = Utility.rotateY(markerVect, calibY);
            //markerVect = MouseUtility.rotateZ(markerVect, calibZ);

            CvInvoke.Line(boardFrame, new Point(0, OPHeight / 2), new Point(OPWidth, OPHeight / 2), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, new Point(OPWidth / 2, 0), new Point(OPWidth / 2, OPHeight), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, Utility.drawVector(markerVect, OPWidth / 2, OPHeight / 2).Item1, Utility.drawVector(markerVect, OPWidth / 2, OPHeight / 2).Item2, new MCvScalar(0, 0, 255), 2);

            if (double.IsNaN(markerVect.X)) markerVect.X = 0;
            if (double.IsNaN(markerVect.Y)) markerVect.Y = 0;
            if (double.IsNaN(markerVect.Z)) markerVect.Z = 0;

            if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, new Point(OPWidth / 2, OPHeight / 2), Math.Abs((int)markerVect.Z), new MCvScalar(0, 0, 255), 1);
            else CvInvoke.Circle(boardFrame, new Point(OPWidth / 2, OPHeight / 2), Math.Abs((int)markerVect.Z), new MCvScalar(255, 0, 0), 1);

            tipOffset.X = (int)markerVect.X;
            tipOffset.Y = (int)markerVect.Y;

            tb_TipOffset.Text = tipOffset.ToString();

            if (showDemo2d)
            {
                CvInvoke.Imshow("OrientationPlane", boardFrame);
            }
            else
            {
                CvInvoke.DestroyWindow("OrientationPlane");
            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_SerialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveSettings();
            MessageBox.Show("Orientation " + Utility.errorList[4]);
        }
        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadSettings();
        }
        private void saveSettings()
        {
            Config.save("OrientOff_X", offsetX);
            Config.save("OrientOff_Y", offsetY);
            Config.save("OrientOff_Z", offsetZ);
        }
        private void loadSettings()
        {
            offsetX = Config.load("OrientOff_X");
            offsetY = Config.load("OrientOff_Y");
            offsetZ = Config.load("OrientOff_Z");
            
            updateControls();
        }
        private void updateControls()
        {
            tb_OffX.Value = offsetX;
            tb_OffY.Value = offsetY;
            tb_OffZ.Value = offsetZ;
            
            trk_OffX.Value = offsetX;
            trk_OffY.Value = offsetY;
            trk_OffZ.Value = offsetZ;
        }

        
    }
}
