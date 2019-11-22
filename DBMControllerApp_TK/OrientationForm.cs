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

namespace DBMControllerApp_TK
{
    public partial class OrientationForm : Form
    {
        private delegate void SetTextDeleg(string text);
        private static OrientationForm instance;
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
        }

        void demo()
        {
            GameWindow window = new GameWindow(500, 500);
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
        }
        private void ProcessSerialFrame(object sender, EventArgs arg)
        {
            string x = serialPort1.ReadLine();
            this.BeginInvoke(new SetTextDeleg(setPortText), new object[] { x });

        }
        private void setPortText(string text)
        {
            string[] data = text.Split('\t');


            if (data.Length == 4 && !data[1].Equals("nan") && !data[2].Equals("nan") && !data[3].Equals("nan"))
            {
                textBox1.Text = text;

                double rotX = (-double.Parse(data[3], System.Globalization.CultureInfo.InvariantCulture));
                double rotY = (-double.Parse(data[2], System.Globalization.CultureInfo.InvariantCulture));
                double rotZ = -double.Parse(data[1], System.Globalization.CultureInfo.InvariantCulture);

                demo3d.zRot = rotZ;
                demo3d.xRot = rotX;
                demo3d.yRot = rotY;

                textBox2.Text = demo3d.calibX.ToString();
                textBox3.Text = demo3d.calibY.ToString();
                textBox4.Text = demo3d.calibZ.ToString();
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
    }
}
