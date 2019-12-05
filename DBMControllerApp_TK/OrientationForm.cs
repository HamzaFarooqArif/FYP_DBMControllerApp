using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO.Ports;
using OpenTK;
using DirectShowLib;
using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DBMControllerApp_TK
{
    public partial class OrientationForm : Form
    {
        private delegate void SetTextDeleg(string text);
        private static OrientationForm instance;
        GameWindow window;
        public static OrientationForm getInstance()
        {
            if(instance == null)
            {
                instance = new OrientationForm();
            }
            return instance;
        }
        private OrientationForm()
        {
            InitializeComponent();

            trk_X.Value = (int)Properties.Settings.Default.Yaw;
            trk_Y.Value = (int)Properties.Settings.Default.Pitch;
            trk_Z.Value = (int)Properties.Settings.Default.Roll;

            tb_XOff.Text = trk_X.Value.ToString();
            tb_YOff.Text = trk_Y.Value.ToString();
            tb_ZOff.Text = trk_Z.Value.ToString();

            BindingSource ports = new BindingSource();
            ports.DataSource = SerialPort.GetPortNames().ToList();
            cb_SerialList.DataSource = ports;

            Thread t1 = new Thread(demo);
            t1.Start();

            Application.Idle += idleEvent;
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            drawOrientationPlane();
        }

        private void drawOrientationPlane()
        {
            int boardWidth = CentralClass.getInstance().boardWidth;
            int boardHeight = CentralClass.getInstance().boardHeight;
            Image<Bgr, byte> boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);

            double calibX = MouseUtility.simplifyAngle(demo3d.calibX);
            double calibY = MouseUtility.simplifyAngle(demo3d.calibY);
            double calibZ = MouseUtility.simplifyAngle(demo3d.calibZ);

            Vector3d markerVect = new Vector3d(0, 0, 100);

            markerVect = MouseUtility.rotateX(markerVect, calibX);
            markerVect = MouseUtility.rotateY(markerVect, calibY);
            //markerVect = MouseUtility.rotateZ(markerVect, calibZ);

            CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, MouseUtility.drawVector(markerVect, boardWidth / 2, boardHeight / 2).Item1, MouseUtility.drawVector(markerVect, boardWidth / 2, boardHeight / 2).Item2, new MCvScalar(0, 0, 255), 2);

            if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, new Point(boardWidth / 2, boardHeight / 2), Math.Abs((int)markerVect.Z), new MCvScalar(0, 0, 255), 1);
            else CvInvoke.Circle(boardFrame, new Point(boardWidth / 2, boardHeight / 2), Math.Abs((int)markerVect.Z), new MCvScalar(255, 0, 0), 1);

            CentralClass.getInstance().tipOffset.X = (int)markerVect.X;
            CentralClass.getInstance().tipOffset.Y = (int)markerVect.Y;

            if (CentralClass.getInstance().showTipOffset)
            {
                CvInvoke.Imshow("OrientationPlane", boardFrame);
            }
            else
            {
                CvInvoke.DestroyWindow("OrientationPlane");
            }
        }
        public void makeVisible(bool visibility)
        {
            if(visibility)
            {
                CentralClass.getInstance().showTipOffset = true;
                CentralClass.getInstance().showDemo3d = true;
            }
            else
            {
                CentralClass.getInstance().showTipOffset = false;
                CentralClass.getInstance().showDemo3d = false;
            }
        }

        void demo()
        {
            window = new GameWindow(500, 500);
            demo3d gm = new demo3d(window);
            
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cb_SerialList.Text) && !serialPort1.IsOpen)
            {
                serialPort1.PortName = cb_SerialList.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(ProcessSerialFrame);
                btn_Start.Text = "Stop Serial";
                cb_SerialList.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(cb_SerialList.Text) && serialPort1.IsOpen)
            {
                serialPort1.Close();
                btn_Start.Text = "Start Serial";
                cb_SerialList.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a valid COM port");
            }
        }
        private void ProcessSerialFrame(object sender, EventArgs arg)
        {
            string x = serialPort1.ReadLine();
            this.BeginInvoke(new SetTextDeleg(setPortText), new object[] { x });

        }
        private void setPortText(string text)
        {
            string[] data = text.Split('\t');


            if (data.Length == 5 && !data[1].Equals("nan") && !data[2].Equals("nan") && !data[3].Equals("nan") && !data[4].Equals("nan"))
            {
                textBox1.Text = text;

                double rotX = (-double.Parse(data[3], System.Globalization.CultureInfo.InvariantCulture));
                double rotY = (-double.Parse(data[2], System.Globalization.CultureInfo.InvariantCulture));
                double rotZ = -double.Parse(data[1], System.Globalization.CultureInfo.InvariantCulture);
                double pressure = double.Parse(data[4], System.Globalization.CultureInfo.InvariantCulture);

                demo3d.zRot = rotZ;
                demo3d.xRot = rotX;
                demo3d.yRot = rotY;
                demo3d.pressure = pressure; 

                textBox2.Text = demo3d.calibX.ToString();
                textBox3.Text = demo3d.calibY.ToString();
                textBox4.Text = demo3d.calibZ.ToString();
                textBox5.Text = demo3d.pressure.ToString();
            }
        }

        private void trk_X_ValueChanged(object sender, EventArgs e)
        {
            demo3d.rotateCAx = trk_X.Value;
            tb_XOff.Text = trk_X.Value.ToString();
        }

        private void trk_Y_ValueChanged(object sender, EventArgs e)
        {
            demo3d.rotateCAy = trk_Y.Value;
            tb_YOff.Text = trk_Y.Value.ToString();
        }

        private void trk_Z_ValueChanged(object sender, EventArgs e)
        {
            demo3d.rotateCAz = trk_Z.Value;
            tb_ZOff.Text = trk_Z.Value.ToString();
        }

        private void OrientationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                makeVisible(false);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to save settings?", "Save Settings", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.Yaw = trk_X.Value;
                Properties.Settings.Default.Pitch = trk_Y.Value;
                Properties.Settings.Default.Roll = trk_Z.Value;
                Properties.Settings.Default.Save();

                MessageBox.Show("Settings Saved");
            }
        }

        private void tb_XOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                trk_X.Value = Int32.Parse(tb_XOff.Text);
            }
        }

        private void tb_YOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                trk_Y.Value = Int32.Parse(tb_YOff.Text);
            }
        }

        private void tb_ZOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                trk_Z.Value = Int32.Parse(tb_ZOff.Text);
            }
        }

        private void OrientationForm_Activated(object sender, EventArgs e)
        {
            makeVisible(true);
        }
    }
}
