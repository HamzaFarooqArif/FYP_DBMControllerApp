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
        private int isTipDown;
        private Point currentPosition;
        private Point previousPosition;
        private int currentTick;
        private bool isTicked;
        private Image<Bgr, Byte> boardFrame;
        private int thickness;
        private Color color;
        private FileHandling dataFile;
        private bool isRecording;
        private bool isPlaying;
        private bool isPaused;
        private int playingIndex;
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
            isTipDown = -1;
            currentPosition = new Point();

            Application.Idle += idleEvent;

            int boardWidth = CentralClass.getInstance().boardWidth;
            int boardHeight = CentralClass.getInstance().boardHeight;
            boardFrame = new Image<Bgr, byte>(boardWidth, boardHeight);
            thickness = 5;
            color = Color.FromArgb(255, 0, 0);
            currentTick = 0;
            isTicked = false;
            dataFile = FileHandling.getInstance(@"C:\Users\Acer\Desktop\demo.txt");
            isRecording = false;
            isPlaying = false;
            playingIndex = 0;
            isPaused = false;

            tipUp();
            rtb_Color.BackColor = color;
            tb_Thickness.Text = thickness.ToString();
            trk_thickness.Value = thickness;

            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.RightClickMenu;

            dataFile.objList.Clear();

            timer1.Start();
            //CvInvoke.Line(boardFrame, new Point(0, boardHeight / 2), new Point(boardWidth, boardHeight / 2), new MCvScalar(255, 255, 255));
            //CvInvoke.Line(boardFrame, new Point(boardWidth / 2, 0), new Point(boardWidth / 2, boardHeight), new MCvScalar(255, 255, 255));

        }

        private void idleEvent(object sender, EventArgs arg)
        {
            draw();
        }

        private void draw()
        {
            if(isRecording)
            {
                if (isTipDown > -1)
                {
                    if (isTicked)
                    {
                        if (isTipDown == 0)
                        {   
                            CvInvoke.Line(boardFrame, previousPosition, previousPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            jsonObj objA = new jsonObj(previousPosition.X, previousPosition.Y, currentTick, thickness, color, isTipDown);
                            dataFile.objList.Add(objA);
                            isTicked = false;
                            isTipDown = -1;
                        }
                        else
                        {
                            CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            jsonObj obj = new jsonObj(currentPosition.X, currentPosition.Y, currentTick, thickness, color, isTipDown);
                            dataFile.objList.Add(obj);
                            isTicked = false;
                            previousPosition = currentPosition;
                        }
                    }
                }
            }
            else if(isPlaying)
            {
                if(playingIndex >= dataFile.objList.Count)
                {
                    isPlaying = false;
                    playingIndex = 0;
                    currentTick = 0;
                    btn_PlayPause.Text = "Play";
                    btn_StartRecord.Enabled = true;
                    tipUp();
                    return;
                }
                jsonObj obj = dataFile.objList[playingIndex];
                currentPosition = new Point(obj.x, obj.y);
                if (isTipDown == 0)
                {
                    previousPosition = currentPosition;
                }
                isTipDown = obj.isTipDown;
                
                if (obj.time <= currentTick)
                {
                    if (isTipDown > -1)
                    {
                        if (isTicked)
                        {
                            //if (isTipDown == 1)
                            //{
                            //    isTipDown = -1;
                            //    CvInvoke.Line(boardFrame, previousPosition, previousPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            //    isTicked = false;
                            //}
                            //else
                            //{
                            //    CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            //    isTicked = false;
                            //    previousPosition = currentPosition;
                            //}
                            CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(obj.color.G, obj.color.B, obj.color.R), obj.thickness);
                            isTicked = false;
                            previousPosition = currentPosition;
                        }
                    }
                    playingIndex++;
                    
                }
            }
            else
            {
                if (isTipDown > 0)
                {
                    if (isTicked)
                    {
                        CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                        isTicked = false;
                        previousPosition = currentPosition;
                    }
                }
            }
            imageBox1.Image = boardFrame;
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
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
            tipDown();
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {

            tipUp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTick++;
            isTicked = true;
        }

        private void btn_StartRecord_Click(object sender, EventArgs e)
        {
            isRecording = !isRecording;
            isPlaying = false;
            isPaused = false;
            isTipDown = -1;
            if (isRecording)
            {
                dataFile.objList.Clear();
                currentTick = 0;
                timer1.Stop();
                timer1.Start();
                btn_StartRecord.Text = "Stop Recording";
                btn_StartRecord.ForeColor = Color.FromArgb(255, 0, 0);
                

                btn_PlayPause.Enabled = false;
                btn_Stop.Enabled = false;
                trk_Seek.Enabled = false;
                txt_Seek.Enabled = false;
            }
            else
            {
                dataFile.saveToFile();
                dataFile.loadFromFile();
                btn_StartRecord.Text = "Start Recording";
                btn_StartRecord.ForeColor = Color.FromArgb(0, 0, 0);
                
                btn_PlayPause.Enabled = true;
                btn_Stop.Enabled = true;
                trk_Seek.Enabled = true;
                txt_Seek.Enabled = true;
            }
        }

        private void tipDown()
        {
            isTipDown = 1;
            previousPosition = currentPosition;
        }

        private void tipUp()
        {
            isTipDown = 0;
        }

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            tipUp();
            if (isPlaying == false)
            {
                currentTick = 0;
                timer1.Stop();
                timer1.Start();
                dataFile.loadFromFile();
                isPlaying = true;
            }

            isPaused = !isPaused;
            if(isPaused)
            {
                btn_PlayPause.Text = "Play";
            }
            else
            {
                btn_PlayPause.Text = "Pause";
                btn_StartRecord.Enabled = false;
            }
            
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            isPaused = false;
            tipUp();
            playingIndex = 0;
            btn_StartRecord.Enabled = true;
        }
    }
}
