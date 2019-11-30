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
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).BeginInit();
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
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
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
    }
}