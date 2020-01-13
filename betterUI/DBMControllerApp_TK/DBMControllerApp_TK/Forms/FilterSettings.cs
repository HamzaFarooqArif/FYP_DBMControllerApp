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
    public partial class FilterSettings : Form
    {
        private static List<FilterSettings> _instance;
        public static FilterSettings getInstance(int idx)
        {
            if (_instance == null)
            {
                _instance = new List<FilterSettings>();
            }
            while (_instance.Count - 1 < idx)
            {
                _instance.Add(new FilterSettings());
            }
            return _instance[idx];
        }
        private FilterSettings()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
