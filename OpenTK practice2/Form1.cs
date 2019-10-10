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

namespace OpenTK_practice2
{
    public partial class Form1 : Form
    {
        private delegate void SetTextDeleg(string text);
        public Form1()
        {
            InitializeComponent();

            BindingSource ports = new BindingSource();
            ports.DataSource = SerialPort.GetPortNames().ToList();
            comboBox1.DataSource = ports;

            Thread t1 = new Thread(demo);
            t1.Start();

        }

        void demo()
        {
            GameWindow window = new GameWindow(500, 500);
            demo3d gm = new demo3d(window);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(comboBox1.Text) && !serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(ProcessSerialFrame);
                button1.Text = "Stop Serial";
                comboBox1.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(comboBox1.Text) && serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Text = "Start Serial";
                comboBox1.Enabled = true;
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
            
            if(data.Length == 4 && !data[1].Equals("nan") && !data[2].Equals("nan") && !data[3].Equals("nan"))
            {
                textBox1.Text = text;

                double rotX = (- double.Parse(data[3], System.Globalization.CultureInfo.InvariantCulture));
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            demo3d.rotateCAx = trackBar4.Value;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            demo3d.rotateCAy = trackBar5.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            demo3d.rotateCAz = trackBar6.Value;
        }
    }
}
