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
        //private bool isBoardErased;
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
            color = Color.FromArgb(255, 255, 255);
            currentTick = 0;
            isTicked = false;
            dataFile = FileHandling.getInstance(@"C:\Users\Acer\Desktop\demo.txt");
            isRecording = false;
            isPlaying = false;
            playingIndex = 0;
            isPaused = false;
            //isBoardErased = true;

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
            if(isRecording && !isPaused)
            {
                if (isTipDown > -1)
                {
                    if (isTicked)
                    {
                        if (isTipDown == 0)
                        {   
                            CvInvoke.Line(boardFrame, previousPosition, previousPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            //if(isBoardErased)
                            //{
                            //    jsonObj obj1 = new jsonObj(0, CentralClass.getInstance().boardHeight/2, currentTick, CentralClass.getInstance().boardWidth/2, Color.FromArgb(0, 0, 0), 1);
                            //    jsonObj obj2 = new jsonObj(CentralClass.getInstance().boardWidth, CentralClass.getInstance().boardHeight / 2, currentTick+1, CentralClass.getInstance().boardWidth/2, Color.FromArgb(0, 0, 0), 1);
                            //    dataFile.objList.Add(obj1);
                            //    dataFile.objList.Add(obj2);
                            //}
                            //else
                            //{

                            //}
                            jsonObj objA = new jsonObj(previousPosition.X, previousPosition.Y, currentTick, thickness, color, isTipDown);
                            dataFile.objList.Add(objA);
                            //isBoardErased = false;
                            isTicked = false;
                            isTipDown = -1;
                        }
                        else
                        {
                            CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(color.B, color.G, color.R), thickness);
                            //if(isBoardErased)
                            //{
                            //    jsonObj obj1 = new jsonObj(0, CentralClass.getInstance().boardHeight / 2, currentTick, CentralClass.getInstance().boardWidth/2, Color.FromArgb(0, 0, 0), 1);
                            //    jsonObj obj2 = new jsonObj(CentralClass.getInstance().boardWidth, CentralClass.getInstance().boardHeight / 2, currentTick+1, CentralClass.getInstance().boardWidth/2, Color.FromArgb(0, 0, 0), 1);
                            //    dataFile.objList.Add(obj1);
                            //    dataFile.objList.Add(obj2);
                            //}
                            //else
                            //{

                            //}
                            jsonObj obj = new jsonObj(currentPosition.X, currentPosition.Y, currentTick, thickness, color, isTipDown);
                            dataFile.objList.Add(obj);
                            //isBoardErased = false;
                            isTicked = false;
                            previousPosition = currentPosition;
                        }
                    }
                }
            }
            else if(isPlaying && !isPaused)
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
                            CvInvoke.Line(boardFrame, previousPosition, currentPosition, new MCvScalar(obj.color.G, obj.color.B, obj.color.R), obj.thickness);
                            //isBoardErased = false;
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
            if (!isPaused)
            {
                currentTick++;
                isTicked = true;
            }
        }

        private void btn_StartRecord_Click(object sender, EventArgs e)
        {
            
            isRecording = !isRecording;
            isPlaying = false;
            isPaused = false;
            isTipDown = -1;
            if (isRecording)
            {
                clearBoard();
                dataFile.objList.Clear();
                currentTick = 0;
                timer1.Stop();
                timer1.Start();
                btn_StartRecord.Text = "Stop Recording";
                btn_StartRecord.ForeColor = Color.FromArgb(255, 0, 0);
                

                btn_PlayPause.Enabled = false;
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
            clearBoard();
            if (!isPlaying)
            {
                currentTick = 0;
                timer1.Stop();
                timer1.Start();
                dataFile.loadFromFile();
                isPlaying = true;
                isPaused = false;
                btn_PlayPause.Text = "Stop";
            }
            else if(isPlaying)
            {
                isPlaying = false;
                isPaused = false;
                tipUp();
                playingIndex = 0;
                btn_StartRecord.Enabled = true;
                btn_PlayPause.Text = "Play";
                button1.Text = "Pause";
                clearBoard();
            }
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            playPause();
        }

        private void playPause()
        {
            if (isPlaying || isRecording)
            {
                isPaused = !isPaused;
                isTipDown = -1;
                if (isPaused)
                {
                    button1.Text = "Resume";
                }
                else
                {
                    button1.Text = "Pause";
                }
            }
        }

        private void btn_Marker_Click(object sender, EventArgs e)
        {
            color = Color.FromArgb(255, 255, 255);
            rtb_Color.BackColor = color;
            thickness = 5;
            trk_thickness.Value = thickness;
            tb_Thickness.Text = thickness.ToString();
        }

        private void btn_duster_Click(object sender, EventArgs e)
        {
            color = Color.FromArgb(0, 0, 0);
            rtb_Color.BackColor = color;
            thickness = 50;
            trk_thickness.Value = thickness;
            tb_Thickness.Text = thickness.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //isBoardErased = true;
            clearBoard();
        }

        private void clearBoard()
        {
            if(!isPaused)
            {
                CvInvoke.Line(boardFrame, new Point(0, CentralClass.getInstance().boardHeight / 2), new Point(CentralClass.getInstance().boardWidth, CentralClass.getInstance().boardHeight / 2), new MCvScalar(0, 0, 0), CentralClass.getInstance().boardWidth);
                if (isRecording)
                {
                    jsonObj obj1 = new jsonObj(0, CentralClass.getInstance().boardHeight / 2, currentTick, CentralClass.getInstance().boardWidth, Color.FromArgb(0, 0, 0), 1);
                    jsonObj obj2 = new jsonObj(CentralClass.getInstance().boardWidth, CentralClass.getInstance().boardHeight / 2, currentTick + 1, CentralClass.getInstance().boardWidth, Color.FromArgb(0, 0, 0), 1);
                    jsonObj obj3 = new jsonObj(CentralClass.getInstance().boardWidth, CentralClass.getInstance().boardHeight / 2, currentTick + 1, CentralClass.getInstance().boardWidth, Color.FromArgb(0, 0, 0), 0);
                    dataFile.objList.Add(obj1);
                    dataFile.objList.Add(obj2);
                    dataFile.objList.Add(obj3);
                }
            }
        }
    }
}
