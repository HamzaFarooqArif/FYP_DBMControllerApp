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
using DBMControllerApp_TK.Utilities;

namespace DBMControllerApp_TK
{
    public partial class Cam_FilterProp : Form
    {
        public Hsv upper;
        public Hsv lower;

        private int formIdx;
        private static List<Cam_FilterProp> instances;
        public static Cam_FilterProp getInstance(int idx)
        {
            if(instances == null)
            {
                instances = new List<Cam_FilterProp>();
            }
            while(instances.Count < idx + 1)
            {
                Cam_FilterProp item = new Cam_FilterProp(idx);
                instances.Add(item);
            }
            return instances[idx];
        } 
        private Cam_FilterProp(int idx)
        {
            InitializeComponent();

            formIdx = idx;
            lbl_Heading.Text = "Camera " + (formIdx + 1) + " Filter Properties";

            upper = new Hsv();
            lower = new Hsv();

            if(formIdx == 0)
            {
                upper.H = CentralClass.getInstance().upper1.H;
                upper.S = CentralClass.getInstance().upper1.S;
                upper.V = CentralClass.getInstance().upper1.V;

                lower.H = CentralClass.getInstance().lower1.H;
                lower.S = CentralClass.getInstance().lower1.S;
                lower.V = CentralClass.getInstance().lower1.V;
            }
            else if (formIdx == 1)
            {
                upper.H = CentralClass.getInstance().upper2.H;
                upper.S = CentralClass.getInstance().upper2.S;
                upper.V = CentralClass.getInstance().upper2.V;

                lower.H = CentralClass.getInstance().lower2.H;
                lower.S = CentralClass.getInstance().lower2.S;
                lower.V = CentralClass.getInstance().lower2.V;
            }

            tb_HueU.Text = upper.H.ToString();
            tb_SatU.Text = upper.S.ToString();
            tb_ValU.Text = upper.V.ToString();

            tb_HueL.Text = lower.H.ToString();
            tb_SatL.Text = lower.S.ToString();
            tb_ValL.Text = lower.V.ToString();

            trk_HueU.Value = (int)upper.H;
            trk_SatU.Value = (int)upper.S;
            trk_ValU.Value = (int)upper.V;

            trk_HueL.Value = (int)lower.H;
            trk_SatL.Value = (int)lower.S;
            trk_ValL.Value = (int)lower.V;

            updateColorBox();
        }

        private void Cam1_FilterProp_Load(object sender, EventArgs e)
        {
            
        }

        private void trk_HueU_ValueChanged(object sender, EventArgs e)
        {
            if(trk_HueU.Focused)
            {
                upper.H = trk_HueU.Value;
                tb_HueU.Text = upper.H.ToString();
                updateColorBox();
            }
        }

        private void tb_HueU_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().Equals("Return"))
            {
                upper.H = Int32.Parse(tb_HueU.Text);
                trk_HueU.Value = (int)upper.H;
                updateColorBox();
            }
        }

        private void trk_SatU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatU.Focused)
            {
                upper.S = trk_SatU.Value;
                tb_SatU.Text = upper.S.ToString();
                updateColorBox();
            }
        }

        private void tb_SatU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                upper.S = Int32.Parse(tb_SatU.Text);
                trk_SatU.Value = (int)upper.S;
                updateColorBox();
            }
        }

        private void trk_ValU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValU.Focused)
            {
                upper.V = trk_ValU.Value;
                tb_ValU.Text = upper.V.ToString();
                updateColorBox();
            }
        }

        private void tb_ValU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                upper.V = Int32.Parse(tb_ValU.Text);
                trk_ValU.Value = (int)upper.V;
                updateColorBox();
            }
        }

        private void trk_HueL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_HueL.Focused)
            {
                lower.H = trk_HueL.Value;
                tb_HueL.Text = lower.H.ToString();
                updateColorBox();
            }
        }

        private void tb_HueL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.H = Int32.Parse(tb_HueL.Text);
                trk_HueL.Value = (int)lower.H;
                updateColorBox();
            }
        }

        private void trk_SatL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatL.Focused)
            {
                lower.S = trk_SatL.Value;
                tb_SatL.Text = lower.S.ToString();
                updateColorBox();
            }
        }

        private void tb_SatL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.S = Int32.Parse(tb_SatL.Text);
                trk_SatL.Value = (int)lower.S;
                updateColorBox();
            }
        }

        private void trk_ValL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValL.Focused)
            {
                lower.V = trk_ValL.Value;
                tb_ValL.Text = lower.V.ToString();
                updateColorBox();
            }
        }

        private void tb_ValL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.V = Int32.Parse(tb_ValL.Text);
                trk_ValL.Value = (int)lower.V;
                updateColorBox();
            }
        }

        private void updateColorBox()
        {
            Hsv upperActual = new Hsv();
            Hsv lowerActual = new Hsv();

            upperActual.H = (upper.H/255)*360;
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
            
            if(formIdx == 0)
            {
                CentralClass.getInstance().upper1 = upper;
                CentralClass.getInstance().lower1 = lower;
            }
            else if (formIdx == 1)
            {
                CentralClass.getInstance().upper2 = upper;
                CentralClass.getInstance().lower2 = lower;
            }
        }

        private void Cam_FilterProp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
