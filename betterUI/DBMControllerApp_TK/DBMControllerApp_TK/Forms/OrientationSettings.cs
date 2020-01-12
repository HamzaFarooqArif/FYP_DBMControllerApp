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
    public partial class OrientationSettings : Form
    {
        private static OrientationSettings _instance;
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
        }

        private void OrientationSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
