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
    public partial class CameraSettings : Form
    {
        private static CameraSettings _instance;
        public static CameraSettings getInstance()
        {
            if(_instance == null)
            {
                _instance = new CameraSettings();
            }
            return _instance;
        }
        private CameraSettings()
        {
            InitializeComponent();
        }

        private void CameraSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
