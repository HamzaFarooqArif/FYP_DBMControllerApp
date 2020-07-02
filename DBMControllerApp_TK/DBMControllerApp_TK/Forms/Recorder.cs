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
        private bool makeTipDown;
        private int playIdx;
        private jsonObj currentJson;
        private string fullPath;
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
            makeTipDown = false;
            fullPath = @"C:\";
            Animation.objList = new List<jsonObj>();
            playIdx = 0;
            timer.Start();
        }
        private void updateControls()
        {
            if(makeTipDown)
            {
                makeTipDown = false;
                isTipDown = 1;
            }
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
            //if (!timer.Enabled) timer.Start();
            if(isPlaying && !trk_Seek.Focused)
            {
                if(trk_Seek.Maximum >= currentTick) trk_Seek.Value = currentTick;
            }
            if(isMarkerSelected) btn_duster.Text = "Duster";
            else btn_duster.Text = "Marker";
            if (isHardwareEnabled) btn_Enable.Text = "Disable Device Input";
            else btn_Enable.Text = "Enable Device Input";
            if (isPaused)
            {
                btn_PlayPause.Text = "Resume";
                timer.Stop();
            }
            else
            {
                btn_PlayPause.Text = "Pause";
                timer.Start();
            }
            if (isRecording)
            {
                //btn_StartRecord.Text = "Stop Recording";
                if (btn_StartRecord.Enabled) btn_StartRecord.Enabled = false;
                if (btn_StartPlay.Enabled) btn_StartPlay.Enabled = false;
                if (btn_Enable.Enabled) btn_Enable.Enabled = false;
                if (tb_OffX.Enabled) tb_OffX.Enabled = false;
                if (btn_SaveFile.Enabled) btn_SaveFile.Enabled = false;
                if (btn_LoadFile.Enabled) btn_LoadFile.Enabled = false;
                if (trk_Seek.Enabled) trk_Seek.Enabled = false;

                if (!btn_StopRecording.Enabled) btn_StopRecording.Enabled = true;
                //if (!btn_StartRecord.Enabled) btn_StartRecord.Enabled = true;
                if (!btn_duster.Enabled) btn_duster.Enabled = true;
                if (!button2.Enabled) button2.Enabled = true;
                if (!trk_thickness.Enabled) trk_thickness.Enabled = true;
                if (!tb_Thickness.Enabled) tb_Thickness.Enabled = true;
                if (!rtb_Color.Enabled) rtb_Color.Enabled = true;
                if (!btn_PlayPause.Enabled) btn_PlayPause.Enabled = true;

            }
            //else
            //{
            //    if (!btn_StartRecord.Enabled) btn_StartRecord.Enabled = true;
            //    if (btn_StopRecording.Enabled) btn_StopRecording.Enabled = false;
            //    //btn_StartRecord.Text = "Start Recording";
            //}
            
            else if (isPlaying)
            {
                btn_StartPlay.Text = "Stop Playing";
                
                if (btn_StartRecord.Enabled) btn_StartRecord.Enabled = false;
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
                if (!trk_Seek.Enabled) trk_Seek.Enabled = true;
            }
            //else btn_StartPlay.Text = "Start Playing";
            else if(!isPlaying && !isRecording)
            {
                btn_StartPlay.Text = "Start Playing";
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
                if (trk_Seek.Enabled) trk_Seek.Enabled = false;
                if (btn_StopRecording.Enabled) btn_StopRecording.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!isPaused && (isRecording || isPlaying)) currentTick++;
            if (isHardwareEnabled)
            {
                hardwareDraw();
            }
            if (!isPlaying && isMoved())
            {
                drawHoverPoint(ref hoverFrame);
            }
            if(isTipDown == 1)
            {
                drawLine(ref frame);
            }
            if(isPlaying && !isPaused)
            {
                playAnim();
            }
            
            suspendMove();
            updateControls();
        }
        private void playAnim()
        {
            if (Animation.videoFrames == null || Animation.videoFrames.Count - 1 < playIdx)
            {
                isPlaying = false;
                isRecording = false;
                isPaused = false;
                return;
            }
            if(playIdx > -1)
            {
                currentJson = Animation.objList[playIdx];
                if (currentJson.time <= currentTick)
                {
                    frame = Animation.videoFrames[playIdx];
                    playIdx++;
                }
            }
            else
            {
                clearBoard();
            }
            
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
                if (isRecording)
                {
                    Animation.appendObj(currentPoint, currentTick, (thickness * Utility.boardHeight) / 75, Color.FromArgb(0, 0, 0), 1);
                }
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
            if (Animation.objList == null || Animation.objList.Count < 1)
            {
                MessageBox.Show(Utility.errorList[5]);
                return;
            }
            isPlaying = !isPlaying;
            if(isPlaying)
            {
                //prevPoint = new Point();
                //currentPoint = new Point();
                currentTick = 0;
                playIdx = 0;
                Utility.boardWidth = Animation.width;
                Utility.boardHeight = Animation.height;
                tickResolution = Animation.tickResolution;
                clearBoard();
                Animation.prepareVideo();
                trk_Seek.Maximum = (int)Animation.objList[Animation.objList.Count - 2].time;
            }
            isRecording = false;
            isPaused = false;
            //currentTick = 0;
            updateControls();
        }
        private void btn_Enable_Click(object sender, EventArgs e)
        {
            isHardwareEnabled = !isHardwareEnabled;
            updateControls();
        }
        private void ib_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            if(!isHardwareEnabled)
            {
                if (!isPlaying)
                {
                    currentPoint.X = (int)Map(e.X, 0, ib_Preview.Width, 0, Utility.boardWidth);
                    currentPoint.Y = (int)Map(e.Y, 0, ib_Preview.Height, 0, Utility.boardHeight);
                    makeTipDown = true;
                    //isTipDown = 1;
                    //Console.WriteLine(currentPoint);
                }
            }
        }
        private void ib_Preview_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isHardwareEnabled)
            {
                if (!isPlaying)
                {
                    isTipDown = 0;
                    if (isRecording)
                    {
                        appendEndPoint();
                    }
                }
            }
        }
        private void ib_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isHardwareEnabled && !isPlaying)
            {
                currentPoint.X = (int)Map(e.X, 0, ib_Preview.Width, 0, Utility.boardWidth);
                currentPoint.Y = (int)Map(e.Y, 0, ib_Preview.Height, 0, Utility.boardHeight);
                //updateControls();
            }
        }
        private void ib_Preview_MouseEnter(object sender, EventArgs e)
        {
            if(!isHardwareEnabled)
            {
                isMouseOver = true;
            }
        }
        private void ib_Preview_MouseLeave(object sender, EventArgs e)
        {
            if (!isHardwareEnabled)
            {
                isMouseOver = false;
            }
            //ib_Preview.Image = frame;
        }
        private void hardwareDraw()
        {
            isMouseOver = true;
            if(!isPlaying)
            {
                currentPoint.X = PositionSettings.getInstance().actualPosition.X;
                currentPoint.Y = PositionSettings.getInstance().actualPosition.Y;
                if(OrientationSettings.getInstance().pressure > 100)
                {
                    isTipDown = 1;
                }
                else
                {
                    isTipDown = 0;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearBoard();
            updateControls();
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
                Animation.tickResolution = tickResolution;
                Animation.width = Utility.boardWidth;
                Animation.height = Utility.boardHeight;
                Animation.objList.Clear();
                currentTick = 0;
                clearBoard();
            }
            //if (!isRecording) Animation.saveToFile(fullPath, tickResolution);
            isPlaying = false;
            isPaused = false;
            //currentTick = 0;
            updateControls();
        }
        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            updateControls();
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
            if(isRecording)
            {
                Animation.appendObj(new Point(0, Utility.boardHeight / 2), currentTick, (thickness * Utility.boardHeight), Color.FromArgb(0, 0, 0), 1);
                Animation.appendObj(new Point(Utility.boardWidth, Utility.boardHeight / 2), currentTick, (thickness * Utility.boardHeight), Color.FromArgb(0, 0, 0), 0);
            }
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
                Utility.boardWidth = Animation.width;
                Utility.boardHeight = Animation.height;
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = fullPath;
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fullPath = saveFileDialog.FileName;
                Animation.saveToFile(fullPath, Utility.boardWidth, Utility.boardHeight, tickResolution);
            }
        }

        private void btn_StopRecording_Click(object sender, EventArgs e)
        {
            isRecording = !isRecording;
            if (isRecording)
            {
                Animation.tickResolution = tickResolution;
                Animation.width = Utility.boardWidth;
                Animation.height = Utility.boardHeight;
                Animation.objList.Clear();
                currentTick = 0;
                clearBoard();
            }
            //if (!isRecording) Animation.saveToFile(fullPath, tickResolution);
            isPlaying = false;
            isPaused = false;
            //currentTick = 0;
            updateControls();
        }

        private void trk_Seek_ValueChanged(object sender, EventArgs e)
        {
            if(trk_Seek.Focused)
            {
                currentTick = trk_Seek.Value;
                refreshPlayIdx();
                playAnim();
                updateControls();
            }
        }
        private void refreshPlayIdx()
        {
            if(Animation.objList[0].time > currentTick)
            {
                playIdx = -1;
                return;
            }
            int i;
            for(i = 0; i < Animation.objList.Count; i++)
            {
                
                if (Animation.objList[i].time >= currentTick)
                {
                    playIdx = i;
                    return;
                }
            }
        }

        private void trk_Seek_MouseDown(object sender, MouseEventArgs e)
        {
            //timer.Stop();
            isPaused = true;
        }

        private void trk_Seek_MouseUp(object sender, MouseEventArgs e)
        {
            //timer.Start();
        }
    }
}
