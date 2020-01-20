using DBMControllerApp_TK.Utilities;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Mat hoverFrame;
        private Point currentPoint;
        private Point prevPoint;
        private bool isMarkerSelected;
        private bool isRecording;
        private bool isPlaying;
        private bool isPaused;
        private bool isHardwareEnabled;
        private bool isMouseOver;
        private int isTipDown;
        string fullPath;
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
            hoverFrame = new Image<Bgr, byte>(Utility.boardWidth, Utility.boardHeight).Mat;
            currentTick = 0;
            thickness = (int)tb_Thickness.Minimum;
            tickResolution = (int)tb_OffX.Minimum;
            color = rtb_Color.BackColor;
            currentPoint = new Point();
            isMarkerSelected = true;
            isRecording = false;
            isPlaying = false;
            isPaused = false;
            isHardwareEnabled = false;
            isMouseOver = false;
            isTipDown = 0;
            fullPath = @"C:\";
            Animation.objList = new List<jsonObj>();
        }
        private void updateControls()
        {
            if (isMouseOver && !isPlaying) ib_Preview.Image = hoverFrame;
            else ib_Preview.Image = frame;
            if (!ib_Preview.FunctionalMode.Equals(ImageBox.FunctionalModeOption.Minimum)) ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            if (!ib_Preview.SizeMode.Equals(PictureBoxSizeMode.StretchImage)) ib_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            trk_thickness.Value = thickness;
            tb_Thickness.Value = thickness;
            tb_OffX.Value = tickResolution;
            rtb_Color.BackColor = color;
            tb_Seek.Text = currentTick.ToString();
            tb_Position.Text = currentPoint.ToString();
            timer.Interval = tickResolution;
            if (!timer.Enabled) timer.Start();
            if(isMarkerSelected) btn_duster.Text = "Duster";
            else btn_duster.Text = "Marker";
            if (isHardwareEnabled) btn_Enable.Text = "Disable Device Input";
            else btn_Enable.Text = "Enable Device Input";
            if (isPaused) btn_PlayPause.Text = "Resume";
            else btn_PlayPause.Text = "Pause";
            if (isRecording)
            {
                btn_StartRecord.Text = "Stop Recording";
                
                if(btn_StartPlay.Enabled) btn_StartPlay.Enabled = false;
                if (btn_Enable.Enabled) btn_Enable.Enabled = false;
                if (tb_OffX.Enabled) tb_OffX.Enabled = false;
                if (btn_SaveFile.Enabled) btn_SaveFile.Enabled = false;
                if (btn_LoadFile.Enabled) btn_LoadFile.Enabled = false;

                if (!btn_StartRecord.Enabled) btn_StartRecord.Enabled = true;
                if (!btn_duster.Enabled) btn_duster.Enabled = true;
                if (!button2.Enabled) button2.Enabled = true;
                if (!trk_thickness.Enabled) trk_thickness.Enabled = true;
                if (!tb_Thickness.Enabled) tb_Thickness.Enabled = true;
                if (!rtb_Color.Enabled) rtb_Color.Enabled = true;
                if (!btn_PlayPause.Enabled) btn_PlayPause.Enabled = true;

            }
            else btn_StartRecord.Text = "Start Recording";
            if (isPlaying)
            {
                btn_StartPlay.Text = "Stop Playing";
                
                if(btn_StartRecord.Enabled) btn_StartRecord.Enabled = false;
                if (btn_duster.Enabled) btn_duster.Enabled = false;
                if (button2.Enabled) button2.Enabled = false;
                if (btn_Enable.Enabled) btn_Enable.Enabled = false;
                if (trk_thickness.Enabled) trk_thickness.Enabled = false;
                if (tb_Thickness.Enabled) tb_Thickness.Enabled = false;
                if (tb_OffX.Enabled) tb_OffX.Enabled = false;
                if (rtb_Color.Enabled) rtb_Color.Enabled = false;
                if (btn_SaveFile.Enabled) btn_SaveFile.Enabled = false;
                if (btn_LoadFile.Enabled) btn_LoadFile.Enabled = false;

                if (!btn_PlayPause.Enabled) btn_PlayPause.Enabled = true;
            }
            else btn_StartPlay.Text = "Start Playing";
            if(!isPlaying && !isRecording)
            {
                if (!btn_StartPlay.Enabled) btn_StartPlay.Enabled = true;
                if (!btn_Enable.Enabled) btn_Enable.Enabled = true;
                if (!tb_OffX.Enabled) tb_OffX.Enabled = true;
                if (!btn_StartRecord.Enabled) btn_StartRecord.Enabled = true;
                if (!btn_duster.Enabled) btn_duster.Enabled = true;
                if (!button2.Enabled) button2.Enabled = true;
                if (!trk_thickness.Enabled) trk_thickness.Enabled = true;
                if (!tb_Thickness.Enabled) tb_Thickness.Enabled = true;
                if (!rtb_Color.Enabled) rtb_Color.Enabled = true;
                if (!btn_SaveFile.Enabled) btn_SaveFile.Enabled = true;
                if (!btn_LoadFile.Enabled) btn_LoadFile.Enabled = true;

                if (btn_PlayPause.Enabled) btn_PlayPause.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!isPaused && (isRecording || isPlaying)) currentTick++;
            if (!isPlaying && isMoved())
            {
                drawHoverPoint(ref hoverFrame);
            }
            if(isTipDown == 1)
            {
                drawLine(ref frame);
            }
            suspendMove();
            updateControls();
        }

        private void drawHoverPoint(ref Mat hoverFrame)
        {
            hoverFrame = frame.Clone();
            if (isMarkerSelected)
            {
                CvInvoke.Circle(hoverFrame, currentPoint, (thickness * Utility.boardHeight) / 400, new MCvScalar(color.B, color.G, color.R), (thickness * Utility.boardHeight) / 200);
            }
            else
            {
                CvInvoke.Circle(hoverFrame, currentPoint, (thickness * Utility.boardHeight) / 50, new MCvScalar(color.B, color.G, color.R), 1);
            }
        }
        
        private void drawLine(ref Mat frame)
        {
            if (isMarkerSelected)
            {
                CvInvoke.Line(frame, prevPoint, currentPoint, new MCvScalar(color.B, color.G, color.R), (thickness * Utility.boardHeight) / 100);
                if (isRecording)
                {
                    Animation.appendObj(currentPoint, currentTick, thickness, color, 1);
                }
            }
            else
            {
                CvInvoke.Line(frame, prevPoint, currentPoint, new MCvScalar(0, 0, 0), (thickness * Utility.boardHeight) / 25);
            }
        }
        
        private void ib_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            if(!isHardwareEnabled && !isPlaying)
            {
                currentPoint.X = (int)Map(e.X, 0, ib_Preview.Width, 0, Utility.boardWidth);
                currentPoint.Y = (int)Map(e.Y, 0, ib_Preview.Height, 0, Utility.boardHeight);
                //updateControls();
            }
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
            if(isPlaying)
            {
                clearBoard();
            }
            isRecording = false;
            isPaused = false;
            currentTick = 0;
            updateControls();
        }
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            isHardwareEnabled = !isHardwareEnabled;
            updateControls();
        }
        private void ib_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            if(!isPlaying)
            {
                isTipDown = 1;
            }
        }
        private void ib_Preview_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isPlaying)
            {
                isTipDown = 0;
                if(isRecording)
                {
                    appendEndPoint();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearBoard();
            updateControls();
        }
        private void ib_Preview_MouseEnter(object sender, EventArgs e)
        {
            isMouseOver = true;
        }
        private void ib_Preview_MouseLeave(object sender, EventArgs e)
        {
            isMouseOver = false;
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
            if (isRecording)
            {
                Animation.objList.Clear();
                clearBoard();
            }
            //if (!isRecording) Animation.saveToFile(fullPath, tickResolution);
            isPlaying = false;
            isPaused = false;
            currentTick = 0;
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
        private void appendEndPoint()
        {
            if (isMarkerSelected)
            {
                Animation.appendObj(currentPoint, currentTick, thickness, color, 0);
            }
            else
            {
                Animation.appendObj(currentPoint, currentTick, thickness, Color.FromArgb(0, 0, 0), 0);
            }
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
        private void clearBoard()
        {
            CvInvoke.Line(frame, new Point(0, Utility.boardHeight / 2), new Point(Utility.boardWidth, Utility.boardHeight / 2), new MCvScalar(0, 0, 0), Utility.boardHeight);
            ib_Preview.Image = frame;
        }
        private bool isMoved()
        {
            return (currentPoint.X != prevPoint.X && currentPoint.Y != prevPoint.Y);
        }
        private void suspendMove()
        {
            prevPoint = currentPoint;
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = fullPath;
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog.FileName;
                Animation.loadFromFile(fullPath);
                tickResolution = Animation.tickResolution;
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = fullPath;
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = saveFileDialog.FileName;
                Animation.saveToFile(fullPath, tickResolution);
            }
        }
    }
}
