namespace DBMControllerApp_TK
{
    partial class OrientationForm
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.cb_SerialList = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trk_X = new System.Windows.Forms.TrackBar();
            this.trk_Y = new System.Windows.Forms.TrackBar();
            this.trk_Z = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trk_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Z)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start Serial";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cb_SerialList
            // 
            this.cb_SerialList.FormattingEnabled = true;
            this.cb_SerialList.Location = new System.Drawing.Point(151, 14);
            this.cb_SerialList.Name = "cb_SerialList";
            this.cb_SerialList.Size = new System.Drawing.Size(121, 21);
            this.cb_SerialList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // trk_X
            // 
            this.trk_X.Location = new System.Drawing.Point(12, 93);
            this.trk_X.Maximum = 360;
            this.trk_X.Name = "trk_X";
            this.trk_X.Size = new System.Drawing.Size(260, 45);
            this.trk_X.TabIndex = 3;
            this.trk_X.ValueChanged += new System.EventHandler(this.trk_X_ValueChanged);
            // 
            // trk_Y
            // 
            this.trk_Y.Location = new System.Drawing.Point(12, 144);
            this.trk_Y.Maximum = 360;
            this.trk_Y.Name = "trk_Y";
            this.trk_Y.Size = new System.Drawing.Size(260, 45);
            this.trk_Y.TabIndex = 4;
            this.trk_Y.ValueChanged += new System.EventHandler(this.trk_Y_ValueChanged);
            // 
            // trk_Z
            // 
            this.trk_Z.Location = new System.Drawing.Point(12, 195);
            this.trk_Z.Maximum = 360;
            this.trk_Z.Name = "trk_Z";
            this.trk_Z.Size = new System.Drawing.Size(260, 45);
            this.trk_Z.TabIndex = 5;
            this.trk_Z.ValueChanged += new System.EventHandler(this.trk_Z_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 8;
            // 
            // OrientationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trk_Z);
            this.Controls.Add(this.trk_Y);
            this.Controls.Add(this.trk_X);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_SerialList);
            this.Controls.Add(this.btn_Start);
            this.Name = "OrientationForm";
            this.Text = "OrientationForm";
            ((System.ComponentModel.ISupportInitialize)(this.trk_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cb_SerialList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trk_X;
        private System.Windows.Forms.TrackBar trk_Y;
        private System.Windows.Forms.TrackBar trk_Z;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}