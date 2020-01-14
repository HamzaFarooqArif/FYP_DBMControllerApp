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
        public int offsetX;
        public int offsetY;
        public int offsetZ;
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
    }
}
