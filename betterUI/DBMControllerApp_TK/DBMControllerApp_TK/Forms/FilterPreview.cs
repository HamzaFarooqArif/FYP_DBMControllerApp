using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
namespace DBMControllerApp_TK.Forms
{
    public partial class FilterPreview : Form
    {
        public static List<FilterPreview> _instance;
        public int formIdx;
        public static FilterPreview getInstance(int idx)
        {
            if (_instance == null)
            {
                _instance = new List<FilterPreview>();
            }
            while (_instance.Count - 1 < idx)
            {
                _instance.Add(new FilterPreview());
            }
            return _instance[idx];
        }
        private FilterPreview()
        {
            InitializeComponent();
            formIdx = _instance.Count;
            this.Text = "Filter Preview " + (formIdx + 1);
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void setImage(Mat frame)
        {
            ib_Preview.Image = frame;
        }
        public void startAll()
        {
            ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void stopAll()
        {
            ib_Preview.Image = new Image<Bgra, byte>(DBMControllerApp_TK.Properties.Resources.Dummy_Preview);
            ib_Preview.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void FilterPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
