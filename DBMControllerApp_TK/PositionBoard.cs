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
    public partial class PositionBoard : Form
    {
        private static PositionBoard instance;
        private bool invertLeftPos;
        private bool invertRightPos;
        public static PositionBoard getInstance()
        {
            if (instance == null) instance = new PositionBoard();
            return instance;
        }
        private PositionBoard()
        {
            InitializeComponent();
            invertLeftPos = Properties.Settings.Default.InvertLeftPos;
            invertRightPos = Properties.Settings.Default.InvertRightPos;

            Application.Idle += idleEvent;
        }

        private void idleEvent(object sender, EventArgs arg)
        {
            drawBoard();
        }
        private void drawBoard()
        {
            int boardWidth = CentralClass.getInstance().boardWidth;
            int boardHeight = CentralClass.getInstance().boardHeight;
            float sizeFactor = 0.5f;

            Image<Bgr, byte> boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);
            Point line1p1 = new Point((int)((float)boardWidth * (float)0.1), (int)((float)boardHeight * (float)0.1));
            Point line1p2 = new Point(boardWidth, boardHeight);
            Point line2p1 = new Point((int)((float)boardWidth * (float)0.9), (int)((float)boardHeight * (float)0.1));
            Point line2p2 = new Point(0, boardHeight);


            if(invertLeftPos) line1p2 = MouseUtility.getInstance(0).rotate(line1p2, line1p1, (float)11.5 + MouseUtility.getInstance(0).getAngleFromPercent(MouseUtility.getInstance(0).position));
            else line1p2 = MouseUtility.getInstance(0).rotate(line1p2, line1p1, (float)11.5 - MouseUtility.getInstance(0).getAngleFromPercent(MouseUtility.getInstance(0).position));
            if (invertRightPos) line2p2 = MouseUtility.getInstance(1).rotate(line2p2, line2p1, (float)-11.5 - MouseUtility.getInstance(1).getAngleFromPercent(MouseUtility.getInstance(1).position));
            else line2p2 = MouseUtility.getInstance(1).rotate(line2p2, line2p1, (float)-11.5 + MouseUtility.getInstance(1).getAngleFromPercent(MouseUtility.getInstance(1).position));
            
            //line1p2 = MouseUtility.getInstance(0).getEndPoints(boardHeight, boardWidth, line1p1, line1p2)[1];
            //line2p2 = MouseUtility.getInstance(1).getEndPoints(boardHeight, boardWidth, line2p1, line2p2)[1];

            CvInvoke.Circle(boardFrame, line1p1, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line1p2, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line2p1, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Circle(boardFrame, line2p2, 5, new MCvScalar(255, 0, 0), 2);
            CvInvoke.Line(boardFrame, line1p1, line1p2, new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, line2p1, line2p2, new MCvScalar(255, 255, 255));

            //CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), 5, new MCvScalar(255, 255, 255), 5);

            PointF notNeedp1 = new PointF();
            PointF notNeedp2 = new PointF();
            PointF p3 = new PointF();
            bool notNeeda;
            bool notNeedb;
            MouseUtility.FindIntersection(line1p1, line1p2, line2p1, line2p2, out notNeeda, out notNeedb, out p3, out notNeedp1, out notNeedp2);
            Point position = new Point((int)p3.X, (int)p3.Y);

            CvInvoke.Circle(boardFrame, position, 5, new MCvScalar(255, 0, 0), 2);


            double calibX = MouseUtility.simplifyAngle(demo3d.calibX);
            double calibY = MouseUtility.simplifyAngle(demo3d.calibY);
            double calibZ = MouseUtility.simplifyAngle(demo3d.calibZ);

            Vector3d markerVect = new Vector3d(0, 0, 100);

            markerVect = MouseUtility.rotateX(markerVect, calibX);
            markerVect = MouseUtility.rotateY(markerVect, calibY);
            //markerVect = MouseUtility.rotateZ(markerVect, calibZ);
            markerVect.X = markerVect.X * sizeFactor;
            markerVect.Y = markerVect.Y * sizeFactor;
            markerVect.Z = markerVect.Z * sizeFactor;

            Point actualPosition = new Point(MouseUtility.drawVector(markerVect, position.X, position.Y).Item2.X, MouseUtility.drawVector(markerVect, position.X, position.Y).Item2.Y);

            //CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
            //CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));
            CvInvoke.Line(boardFrame, position, actualPosition, new MCvScalar(0, 0, 255), 2);


            //if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(0, 0, 255), 1);
            //else CvInvoke.Circle(boardFrame, MouseUtility.findIntercept(line1p1, line1p2, line2p1, line2p2), Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(255, 0, 0), 1);

            if (markerVect.Z > 0) CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(0, 0, 255), 1);
            else CvInvoke.Circle(boardFrame, position, Math.Abs((int)(markerVect.Z * sizeFactor)), new MCvScalar(255, 0, 0), 1);

            CentralClass.getInstance().tipOffset.X = (int)markerVect.X;
            CentralClass.getInstance().tipOffset.Y = (int)markerVect.Y;

            imageBox1.Image = boardFrame;

            //if (CentralClass.getInstance().showBoard)
            //{
            //    CvInvoke.Imshow("Board", boardFrame);
            //}
            //else
            //{
            //    CvInvoke.DestroyWindow("Board");
            //}
        }

        private void PositionBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btn_InvLeft_Click(object sender, EventArgs e)
        {
            invertLeftPos = !invertLeftPos;
        }

        private void btn_InvRight_Click(object sender, EventArgs e)
        {
            invertRightPos = !invertRightPos;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialog = dialog = MessageBox.Show("Are you sure you want to save settings?", "Save Settings", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Properties.Settings.Default.InvertLeftPos = invertLeftPos;
                Properties.Settings.Default.InvertRightPos = invertRightPos;
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings Saved");
            }
        }
    }
}
