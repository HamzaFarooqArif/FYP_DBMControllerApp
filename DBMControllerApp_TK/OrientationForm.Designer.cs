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
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_XOff = new System.Windows.Forms.TextBox();
            this.tb_YOff = new System.Windows.Forms.TextBox();
            this.tb_ZOff = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.trk_X.Location = new System.Drawing.Point(29, 209);
            this.trk_X.Maximum = 360;
            this.trk_X.Name = "trk_X";
            this.trk_X.Size = new System.Drawing.Size(174, 45);
            this.trk_X.TabIndex = 3;
            this.trk_X.ValueChanged += new System.EventHandler(this.trk_X_ValueChanged);
            // 
            // trk_Y
            // 
            this.trk_Y.Location = new System.Drawing.Point(29, 251);
            this.trk_Y.Maximum = 360;
            this.trk_Y.Name = "trk_Y";
            this.trk_Y.Size = new System.Drawing.Size(174, 45);
            this.trk_Y.TabIndex = 4;
            this.trk_Y.ValueChanged += new System.EventHandler(this.trk_Y_ValueChanged);
            // 
            // trk_Z
            // 
            this.trk_Z.Location = new System.Drawing.Point(29, 293);
            this.trk_Z.Maximum = 360;
            this.trk_Z.Name = "trk_Z";
            this.trk_Z.Size = new System.Drawing.Size(174, 45);
            this.trk_Z.TabIndex = 5;
            this.trk_Z.ValueChanged += new System.EventHandler(this.trk_Z_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(32, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(177, 334);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Orientation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Offsets";
            // 
            // tb_XOff
            // 
            this.tb_XOff.Location = new System.Drawing.Point(209, 209);
            this.tb_XOff.Name = "tb_XOff";
            this.tb_XOff.Size = new System.Drawing.Size(72, 20);
            this.tb_XOff.TabIndex = 18;
            this.tb_XOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_XOff_KeyDown);
            // 
            // tb_YOff
            // 
            this.tb_YOff.Location = new System.Drawing.Point(209, 251);
            this.tb_YOff.Name = "tb_YOff";
            this.tb_YOff.Size = new System.Drawing.Size(72, 20);
            this.tb_YOff.TabIndex = 19;
            this.tb_YOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_YOff_KeyDown);
            // 
            // tb_ZOff
            // 
            this.tb_ZOff.Location = new System.Drawing.Point(209, 293);
            this.tb_ZOff.Name = "tb_ZOff";
            this.tb_ZOff.Size = new System.Drawing.Size(72, 20);
            this.tb_ZOff.TabIndex = 20;
            this.tb_ZOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ZOff_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(209, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pressure";
            // 
            // OrientationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 367);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tb_ZOff);
            this.Controls.Add(this.tb_YOff);
            this.Controls.Add(this.tb_XOff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
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
            this.Activated += new System.EventHandler(this.OrientationForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrientationForm_FormClosing);
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
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_XOff;
        private System.Windows.Forms.TextBox tb_YOff;
        private System.Windows.Forms.TextBox tb_ZOff;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
    }
}