using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ColorMine;
using ColorMine.ColorSpaces;
namespace DBMControllerApp_TK.Forms
{
    public partial class FilterSettings : Form
    {
        private static List<FilterSettings> _instance;
        public Hsv upper;
        public Hsv lower;
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
            upper = new Hsv();
            lower = new Hsv();
            updateColorBox();
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

        private void trk_HueU_ValueChanged(object sender, EventArgs e)
        {
            if(trk_HueU.Focused)
            {
                upper.H = trk_HueU.Value;
                tb_HueU.Value = (int)upper.H;
                updateColorBox();
            }
        }

        
        private void trk_ValL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValL.Focused)
            {
                lower.V = trk_ValL.Value;
                tb_ValL.Value = (int)lower.V;
                updateColorBox();
            }
        }

        private void trk_SatU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatU.Focused)
            {
                upper.S = trk_SatU.Value;
                tb_SatU.Value = (int)upper.S;
                updateColorBox();
            }
        }

        private void trk_ValU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValU.Focused)
            {
                upper.V = trk_ValU.Value;
                tb_ValU.Value = (int)upper.V;
                updateColorBox();
            }
        }

        private void trk_HueL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_HueL.Focused)
            {
                lower.H = trk_HueL.Value;
                tb_HueL.Value = (int)lower.H;
                updateColorBox();
            }
        }

        private void trk_SatL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatL.Focused)
            {
                lower.S = trk_SatL.Value;
                tb_SatL.Value = (int)lower.S;
                updateColorBox();
            }
        }

        private void tb_HueU_ValueChanged(object sender, EventArgs e)
        {
            if(tb_HueU.Focused)
            {
                upper.H = (int)tb_HueU.Value;
                trk_HueU.Value = (int)upper.H;
                updateColorBox();
            }
        }

        private void tb_SatU_ValueChanged(object sender, EventArgs e)
        {
            if (tb_SatU.Focused)
            {
                upper.S = (int)tb_SatU.Value;
                trk_SatU.Value = (int)upper.S;
                updateColorBox();
            }
        }

        private void tb_ValU_ValueChanged(object sender, EventArgs e)
        {
            if (tb_ValU.Focused)
            {
                upper.V = (int)tb_ValU.Value;
                trk_ValU.Value = (int)upper.V;
                updateColorBox();
            }
        }

        private void tb_HueL_ValueChanged(object sender, EventArgs e)
        {
            if (tb_HueL.Focused)
            {
                lower.H = (int)tb_HueL.Value;
                trk_HueL.Value = (int)lower.H;
                updateColorBox();
            }
        }

        private void tb_SatL_ValueChanged(object sender, EventArgs e)
        {
            if (tb_SatL.Focused)
            {
                lower.S = (int)tb_SatL.Value;
                trk_SatL.Value = (int)lower.S;
                updateColorBox();
            }
        }
        private void tb_ValL_ValueChanged(object sender, EventArgs e)
        {
            if (tb_ValL.Focused)
            {
                lower.V = (int)tb_ValL.Value;
                trk_ValL.Value = (int)lower.V;
                updateColorBox();
            }
        }

        private void updateColorBox()
        {
            Hsv upperActual = new Hsv();
            Hsv lowerActual = new Hsv();

            upperActual.H = (upper.H / 255) * 360;
            upperActual.S = upper.S / 255;
            upperActual.V = upper.V / 255;

            lowerActual.H = (lower.H / 255) * 360;
            lowerActual.S = lower.S / 255;
            lowerActual.V = lower.V / 255;

            Rgb uRGB = upperActual.To<Rgb>();
            Color bgColorU = Color.FromArgb((int)uRGB.R, (int)uRGB.G, (int)uRGB.B);
            rtb_U.BackColor = bgColorU;

            Rgb lRGB = lowerActual.To<Rgb>();
            Color bgColorL = Color.FromArgb((int)lRGB.R, (int)lRGB.G, (int)lRGB.B);
            rtb_L.BackColor = bgColorL;
        }
    }
}
