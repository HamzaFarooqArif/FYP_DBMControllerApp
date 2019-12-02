namespace DBMControllerApp_TK
{
    partial class DrawingBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.rtb_Color = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Thickness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Position = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trk_thickness = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_StartRecord = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.trk_Seek = new System.Windows.Forms.TrackBar();
            this.txt_Seek = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Marker = new System.Windows.Forms.Button();
            this.btn_duster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(480, 320);
            this.imageBox1.TabIndex = 3;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // rtb_Color
            // 
            this.rtb_Color.Location = new System.Drawing.Point(310, 347);
            this.rtb_Color.Name = "rtb_Color";
            this.rtb_Color.Size = new System.Drawing.Size(22, 20);
            this.rtb_Color.TabIndex = 4;
            this.rtb_Color.Text = "";
            this.rtb_Color.Click += new System.EventHandler(this.rtb_Color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color";
            // 
            // tb_Thickness
            // 
            this.tb_Thickness.Location = new System.Drawing.Point(216, 347);
            this.tb_Thickness.Name = "tb_Thickness";
            this.tb_Thickness.Size = new System.Drawing.Size(37, 20);
            this.tb_Thickness.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thickness";
            // 
            // tb_Position
            // 
            this.tb_Position.Location = new System.Drawing.Point(407, 347);
            this.tb_Position.Name = "tb_Position";
            this.tb_Position.Size = new System.Drawing.Size(85, 20);
            this.tb_Position.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position";
            // 
            // trk_thickness
            // 
            this.trk_thickness.Location = new System.Drawing.Point(71, 347);
            this.trk_thickness.Maximum = 320;
            this.trk_thickness.Minimum = 1;
            this.trk_thickness.Name = "trk_thickness";
            this.trk_thickness.Size = new System.Drawing.Size(139, 45);
            this.trk_thickness.TabIndex = 10;
            this.trk_thickness.Value = 1;
            this.trk_thickness.ValueChanged += new System.EventHandler(this.trk_thickness_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_StartRecord
            // 
            this.btn_StartRecord.Location = new System.Drawing.Point(12, 397);
            this.btn_StartRecord.Name = "btn_StartRecord";
            this.btn_StartRecord.Size = new System.Drawing.Size(99, 23);
            this.btn_StartRecord.TabIndex = 11;
            this.btn_StartRecord.Text = "Start Recording";
            this.btn_StartRecord.UseVisualStyleBackColor = true;
            this.btn_StartRecord.Click += new System.EventHandler(this.btn_StartRecord_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.Location = new System.Drawing.Point(93, 426);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayPause.TabIndex = 13;
            this.btn_PlayPause.Text = "Play";
            this.btn_PlayPause.UseVisualStyleBackColor = true;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // trk_Seek
            // 
            this.trk_Seek.Location = new System.Drawing.Point(12, 451);
            this.trk_Seek.Name = "trk_Seek";
            this.trk_Seek.Size = new System.Drawing.Size(413, 45);
            this.trk_Seek.TabIndex = 15;
            // 
            // txt_Seek
            // 
            this.txt_Seek.Location = new System.Drawing.Point(431, 451);
            this.txt_Seek.Name = "txt_Seek";
            this.txt_Seek.Size = new System.Drawing.Size(63, 20);
            this.txt_Seek.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Marker
            // 
            this.btn_Marker.Location = new System.Drawing.Point(310, 373);
            this.btn_Marker.Name = "btn_Marker";
            this.btn_Marker.Size = new System.Drawing.Size(75, 23);
            this.btn_Marker.TabIndex = 18;
            this.btn_Marker.Text = "Marker";
            this.btn_Marker.UseVisualStyleBackColor = true;
            this.btn_Marker.Click += new System.EventHandler(this.btn_Marker_Click);
            // 
            // btn_duster
            // 
            this.btn_duster.Location = new System.Drawing.Point(407, 373);
            this.btn_duster.Name = "btn_duster";
            this.btn_duster.Size = new System.Drawing.Size(75, 23);
            this.btn_duster.TabIndex = 19;
            this.btn_duster.Text = "Duster";
            this.btn_duster.UseVisualStyleBackColor = true;
            this.btn_duster.Click += new System.EventHandler(this.btn_duster_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_duster);
            this.Controls.Add(this.btn_Marker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Seek);
            this.Controls.Add(this.trk_Seek);
            this.Controls.Add(this.btn_PlayPause);
            this.Controls.Add(this.btn_StartRecord);
            this.Controls.Add(this.trk_thickness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.tb_Thickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Color);
            this.Name = "DrawingBoard";
            this.Text = "DrawingBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawingBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.RichTextBox rtb_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Thickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trk_thickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_StartRecord;
        private System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.TrackBar trk_Seek;
        private System.Windows.Forms.TextBox txt_Seek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Marker;
        private System.Windows.Forms.Button btn_duster;
        private System.Windows.Forms.Button button2;
    }
}