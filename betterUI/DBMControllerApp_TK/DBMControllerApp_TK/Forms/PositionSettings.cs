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
    public partial class PositionSettings : Form
    {
        private static PositionSettings _instance;
        public static PositionSettings getInstance()
        {
            if (_instance == null)
            {
                _instance = new PositionSettings();
            }
            return _instance;
        }
        private PositionSettings()
        {
            InitializeComponent();

            Application.Idle += idleEvent;
        }
        private void idleEvent(object sender, EventArgs arg)
        {
            
        }

    }
}
