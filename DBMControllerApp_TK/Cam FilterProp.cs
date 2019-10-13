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
            }
        }

        private void tb_HueU_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().Equals("Return"))
            {
                upper.H = Int32.Parse(tb_HueU.Text);
                trk_HueU.Value = (int)upper.H;
            }
        }

        private void trk_SatU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatU.Focused)
            {
                upper.S = trk_SatU.Value;
                tb_SatU.Text = upper.S.ToString();
            }
        }

        private void tb_SatU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                upper.S = Int32.Parse(tb_SatU.Text);
                trk_SatU.Value = (int)upper.S;
            }
        }

        private void trk_ValU_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValU.Focused)
            {
                upper.V = trk_ValU.Value;
                tb_ValU.Text = upper.V.ToString();
            }
        }

        private void tb_ValU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                upper.V = Int32.Parse(tb_ValU.Text);
                trk_ValU.Value = (int)upper.V;
            }
        }

        private void trk_HueL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_HueL.Focused)
            {
                lower.H = trk_HueL.Value;
                tb_HueL.Text = lower.H.ToString();
            }
        }

        private void tb_HueL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.H = Int32.Parse(tb_HueL.Text);
                trk_HueL.Value = (int)lower.H;
            }
        }

        private void trk_SatL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_SatL.Focused)
            {
                lower.S = trk_SatL.Value;
                tb_SatL.Text = lower.S.ToString();
            }
        }

        private void tb_SatL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.S = Int32.Parse(tb_SatL.Text);
                trk_SatL.Value = (int)lower.S;
            }
        }

        private void trk_ValL_ValueChanged(object sender, EventArgs e)
        {
            if (trk_ValL.Focused)
            {
                lower.V = trk_ValL.Value;
                tb_ValL.Text = lower.V.ToString();
            }
        }

        private void tb_ValL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                lower.V = Int32.Parse(tb_ValL.Text);
                trk_ValL.Value = (int)lower.V;
            }
        }
    }
}
