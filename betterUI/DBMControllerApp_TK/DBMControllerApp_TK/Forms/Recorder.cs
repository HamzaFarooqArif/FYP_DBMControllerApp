using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMControllerApp_TK.Forms
{
    public partial class Recorder : Form
    {
        private static Recorder _instance;
        public static Recorder getInstance()
        {
            if (_instance == null)
            {
                _instance = new Recorder();
            }
            return _instance;
        }
        private Recorder()
        {
            InitializeComponent();
        }

        private void Recorder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
