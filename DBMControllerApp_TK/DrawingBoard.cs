using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMControllerApp_TK
{
    public partial class DrawingBoard : Form
    {
        public static DrawingBoard instance;
        private bool isTipDown;
        private Point currentPosition;
        private Point previousPosition;
        private Image<Bgr, Byte> boardFrame;
        private int thickness;
        private Color color;
        public static DrawingBoard getInstance()
        {
            if(instance == null)
            {
                instance = new DrawingBoard();
            }
            return instance;
        }
        private DrawingBoard()
        {
            InitializeComponent();
            isTipDown = false;
            currentPosition = new Point();

            Application.Idle += idleEvent;

            int boardWidth = CentralClass.getInstance().boardWidth;
            int boardHeight = CentralClass.getInstance().boardHeight;
            boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);
            thickness = 5;
            color = Color.FromArgb(255, 0, 0);

            rtb_Color.BackColor = color;
            tb_Thickness.Text = thickness.ToString();
            trk_thickness.Value = thickness;

            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;
            //CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
            //CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));

        }

        private void idleEvent(object sender, EventArgs arg)
        {
            draw();
        }

        private void draw()
        {
            if(isTipDown)
            {
                CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(color.B, color.G, color.R), thickness);
            }
            imageBox1.Image = boardFrame;
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            previousPosition = currentPosition;
            currentPosition.X = e.X;
            currentPosition.Y = e.Y;

            tb_Position.Text = currentPosition.ToString();
            rtb_Color.BackColor = color;
        }

        private void DrawingBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void trk_thickness_ValueChanged(object sender, EventArgs e)
        {
            if(trk_thickness.Focused)
            {
                thickness = trk_thickness.Value;
                tb_Thickness.Text = thickness.ToString();
            }
        }

        private void rtb_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                color = colorDialog1.Color;
                rtb_Color.BackColor = color;
            }
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isTipDown = true;
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isTipDown = false;
        }
    }
}
