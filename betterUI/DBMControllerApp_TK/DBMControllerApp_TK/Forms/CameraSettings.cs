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
        private static List<CameraSettings> _instance;
        private int formIdx;
        public static CameraSettings getInstance(int idx)
        {
            if(_instance == null)
            {
                _instance = new List<CameraSettings>();
            }
            while(_instance.Count - 1 < idx)
            {
                _instance.Add(new CameraSettings());
            }
            return _instance[idx];
        }
        private CameraSettings()
        {
            InitializeComponent();
            formIdx = _instance.Count;
            lbl_CameraIndex.Text = lbl_CameraIndex.Text + " " + (formIdx + 1);
        }

        private void CameraSettings_Load(object sender, EventArgs e)
        {

        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {

        }
    }
}
