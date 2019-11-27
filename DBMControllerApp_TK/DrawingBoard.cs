using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;
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

            CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));

        }

        private void idleEvent(object sender, EventArgs arg)
        {
            draw();
        }

        private void draw()
        {
            
            if(isTipDown)
            {
                CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(0, 0, 255), 5);
            }

            imageBox1.Image = boardFrame;
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            previousPosition = currentPosition;
            currentPosition.X = e.X;
            currentPosition.Y = e.Y;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            isTipDown = !isTipDown;
        }
    }
}
