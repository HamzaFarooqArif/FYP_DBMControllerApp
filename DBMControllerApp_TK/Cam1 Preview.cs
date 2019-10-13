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

namespace DBMControllerApp_TK
{
    public partial class Cam1_Preview : Form
    {
        private static Cam1_Preview instance;
        public Mat frame;
        public static Cam1_Preview getInstance()
        {
            if (instance == null)
            {
                instance = new Cam1_Preview();
            }
            return instance;
        }
        public Cam1_Preview()
        {
            InitializeComponent();
            frame = new Mat();
        }

        public void processFrame(object sender, EventArgs arg)
        {
            Form1.capture0.Retrieve(frame, 0);
            Image<Bgr, byte> abc = frame.ToImage<Bgr, byte>();
            imageBox1.Image = abc;

            
        }
    }
}
