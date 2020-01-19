using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
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
    public partial class Recorder : Form
    {
        private static Recorder _instance;
        private Mat frame;
        private int currentTick;
        private int thickness;
        private int tickResolution;
        private Color color;
        
        private Point hoverPoint;
        private bool isMarkerSelected;
        private bool isRecording;
        private bool isPlaying;
        private bool isPaused;
        private bool isHardwareEnabled;
        public static Recorder getInstance()
        {
            if (_instance == null)
            {
                _instance = new Recorder();
            }
            return _instance;
        }
        private Recorder()
        {
            InitializeComponent();
            initVars();
            updateControls();
            loadSettings();
        }
        private void initVars()
        {
            frame = new Image<Bgr, byte>(Utility.boardWidth, Utility.boardHeight).Mat;
            currentTick = 0;
            thickness = (int)tb_Thickness.Minimum;
            tickResolution = (int)tb_OffX.Minimum;
            color = rtb_Color.BackColor;
            hoverPoint = new Point();
            isMarkerSelected = true;
            isRecording = false;
            isPlaying = false;
            isPaused = false;
            isHardwareEnabled = false;
        }
        private void updateControls()
        {
            ib_Preview.Image = frame;
            if(!ib_Preview.FunctionalMode.Equals(ImageBox.FunctionalModeOption.Minimum)) ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            if (!ib_Preview.SizeMode.Equals(PictureBoxSizeMode.StretchImage)) ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            trk_thickness.Value = thickness;
            tb_Thickness.Value = thickness;
            tb_OffX.Value = tickResolution;
            rtb_Color.BackColor = color;
            tb_Seek.Text = currentTick.ToString();
            tb_Position.Text = hoverPoint.ToString();
            timer.Interval = tickResolution;
            if (!timer.Enabled) timer.Start();
            if(isMarkerSelected) btn_duster.Text = "Marker";
            else btn_duster.Text = "Duster";
            if (isRecording)
            {
                btn_StartRecord.Text = "Stop Recording";
                if(btn_StartPlay.Enabled) btn_StartPlay.Enabled = false;
            }
            else
            {
                btn_StartRecord.Text = "Start Recording";
                if (!btn_StartPlay.Enabled) btn_StartPlay.Enabled = true;
            }
            if (isPlaying)
            {
                btn_StartPlay.Text = "Stop Playing";
                if(btn_StartRecord.Enabled) btn_StartRecord.Enabled = false;
            }
            else
            {
                btn_StartPlay.Text = "Start Playing";
                if (!btn_StartRecord.Enabled) btn_StartRecord.Enabled = true;
            }
            if (isPaused) btn_PlayPause.Text = "Resume";
            else btn_PlayPause.Text = "Pause";
            if (isHardwareEnabled) btn_Enable.Text = "Disable Device Input";
            else btn_Enable.Text = "Enable Device Input";
        }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }
        
        private void drawHover(ref Mat frame)
        {
            //Mat frameLocal = frame.Clone();
            //ib_Preview.Image = frameLocal;
            //if (isMarker)
            //{
            //    CvInvoke.Circle(frameLocal, hoverPoint, (thickness * Utility.boardHeight) / 400, new MCvScalar(color.B, color.G, color.R), (thickness * Utility.boardHeight) / 200);
            //}
            //else
            //{
            //    CvInvoke.Circle(frameLocal, hoverPoint, (thickness * Utility.boardHeight) / 50, new MCvScalar(color.B, color.G, color.R), 1);
            //}
            //ib_Preview.Image = frameLocal;
        }
        private void drawShape(ref Mat frame)
        {
            //if (isMarker)
            //{
            //    CvInvoke.Line(frame, prevPoint, hoverPoint, new MCvScalar(color.B, color.G, color.R), (thickness * Utility.boardHeight) / 100);
            //    if(!isStoppedRecording)
            //    {
            //        Animation.appendObj(hoverPoint, currentTick, thickness, color, 1);
            //    }
            //}
            //else
            //{
            //    CvInvoke.Line(frame, prevPoint, hoverPoint, new MCvScalar(0, 0, 0), (thickness * Utility.boardHeight) / 25);
            //}
            //ib_Preview.Image = frame;
        }
        
        private void clearBoard()
        {
            //CvInvoke.Line(frame, new Point(0, Utility.boardHeight / 2), new Point(Utility.boardWidth, Utility.boardHeight / 2), new MCvScalar(0, 0, 0), Utility.boardHeight);
            //ib_Preview.Image = frame;
        }

        private bool isMoved()
        {
            return true;//(hoverPoint.X != prevPoint.X && hoverPoint.Y != prevPoint.Y);
        }
        private void suspendMove()
        {
            //prevPoint = hoverPoint;
        }
        
        private void ib_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            hoverPoint.X = (int)Map(e.X, 0, ib_Preview.Width, 0, Utility.boardWidth);
            hoverPoint.Y = (int)Map(e.Y, 0, ib_Preview.Height, 0, Utility.boardHeight);
            updateControls();
        }
        
        private void trk_thickness_ValueChanged(object sender, EventArgs e)
        {
            if(trk_thickness.Focused)
            {
                thickness = trk_thickness.Value;
                updateControls();
            }
        }

        private void tb_OffX_ValueChanged(object sender, EventArgs e)
        {
            if(tb_OffX.Focused)
            {
                tickResolution = (int)tb_OffX.Value;
                updateControls();
            }
        }

        private void tb_Thickness_ValueChanged(object sender, EventArgs e)
        {
            if(tb_Thickness.Focused)
            {
                thickness = (int)tb_Thickness.Value;
                updateControls();
            }
        }

        private void rtb_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                updateControls();
            }
        }

        private void btn_duster_Click(object sender, EventArgs e)
        {
            isMarkerSelected = !isMarkerSelected;
            updateControls();
        }
        private void btn_StartPlay_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            isRecording = false;
            isPaused = false;
            updateControls();
        }
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            isHardwareEnabled = !isHardwareEnabled;
            updateControls();
        }

        private void ib_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            //isTipDown = true;
        }

        private void ib_Preview_MouseUp(object sender, MouseEventArgs e)
        {
            //isTipDown = false;
            //appendEndPoint();
        }
        private void appendEndPoint()
        {
            //if(!isStoppedRecording)
            //{
            //    if(isMarker)
            //    {
            //        Animation.appendObj(hoverPoint, currentTick, thickness, color, 0);
            //    }
            //    else
            //    {
            //        Animation.appendObj(hoverPoint, currentTick, thickness, Color.FromArgb(0, 0, 0), 0);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clearBoard();
        }

        private void ib_Preview_MouseLeave(object sender, EventArgs e)
        {
            //ib_Preview.Image = frame;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveSettings();
        }
        

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void btn_StartRecord_Click(object sender, EventArgs e)
        {
            isRecording = !isRecording;
            isPlaying = false;
            isPaused = false;
            updateControls();
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            updateControls();
        }
        private void playAnimation()
        {
            //jsonObj obj = Animation.objList[currentPlayIdx];
            
            //hoverPoint = new Point(obj.x, obj.y);
            //color = obj.color;
            //thickness = obj.thickness;
            //isTipDown = obj.isTipDown != 0;
            //if(isTipDown)
            //{
            //    CvInvoke.Line(frame, prevPoint, hoverPoint, new MCvScalar(color.B, color.G, color.R), (thickness * Utility.boardHeight) / 100);
            //}
            
            //ib_Preview.Image = frame;
            //if(currentPlayIdx < Animation.objList.Count - 1) currentPlayIdx++;
        }
        private void saveSettings()
        {
            Config.save("RecordColor_R", color.R);
            Config.save("RecordColor_G", color.G);
            Config.save("RecordColor_B", color.B);
            Config.save("TickResolution", tickResolution);
            Config.save("Thickness", thickness);
            MessageBox.Show("Recorder " + Utility.errorList[4]);
        }
        private void loadSettings()
        {
            tickResolution = Config.load("TickResolution");
            thickness = Config.load("Thickness");
            int r = Config.load("RecordColor_R");
            int g = Config.load("RecordColor_G");
            int b = Config.load("RecordColor_B");
            color = Color.FromArgb(r, g, b);
            updateControls();
        }
        public float Map(float value, float fromSource, float toSource, float fromTarget, float toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }

        
    }
}
