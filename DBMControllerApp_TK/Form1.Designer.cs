namespace DBMControllerApp_TK
{
    partial class Form1
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
            this.tb_fps1 = new System.Windows.Forms.TextBox();
            this.cb_camList1 = new System.Windows.Forms.ComboBox();
            this.btn_Capture1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_preview2 = new System.Windows.Forms.Button();
            this.tbn_preview1 = new System.Windows.Forms.Button();
            this.btn_Capture2 = new System.Windows.Forms.Button();
            this.tb_fps2 = new System.Windows.Forms.TextBox();
            this.cb_camList2 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Board = new System.Windows.Forms.Button();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_orientation = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fps1
            // 
            this.tb_fps1.Location = new System.Drawing.Point(8, 33);
            this.tb_fps1.Name = "tb_fps1";
            this.tb_fps1.Size = new System.Drawing.Size(100, 20);
            this.tb_fps1.TabIndex = 0;
            this.tb_fps1.Text = "30";
            // 
            // cb_camList1
            // 
            this.cb_camList1.FormattingEnabled = true;
            this.cb_camList1.Location = new System.Drawing.Point(6, 6);
            this.cb_camList1.Name = "cb_camList1";
            this.cb_camList1.Size = new System.Drawing.Size(121, 21);
            this.cb_camList1.TabIndex = 1;
            // 
            // btn_Capture1
            // 
            this.btn_Capture1.Location = new System.Drawing.Point(8, 59);
            this.btn_Capture1.Name = "btn_Capture1";
            this.btn_Capture1.Size = new System.Drawing.Size(75, 23);
            this.btn_Capture1.TabIndex = 2;
            this.btn_Capture1.Text = "Capture";
            this.btn_Capture1.UseVisualStyleBackColor = true;
            this.btn_Capture1.Click += new System.EventHandler(this.btn_Capture1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 280);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Save);
            this.tabPage1.Controls.Add(this.btn_preview2);
            this.tabPage1.Controls.Add(this.tbn_preview1);
            this.tabPage1.Controls.Add(this.btn_Capture2);
            this.tabPage1.Controls.Add(this.tb_fps2);
            this.tabPage1.Controls.Add(this.cb_camList2);
            this.tabPage1.Controls.Add(this.cb_camList1);
            this.tabPage1.Controls.Add(this.btn_Capture1);
            this.tabPage1.Controls.Add(this.tb_fps1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(309, 223);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_preview2
            // 
            this.btn_preview2.Location = new System.Drawing.Point(140, 88);
            this.btn_preview2.Name = "btn_preview2";
            this.btn_preview2.Size = new System.Drawing.Size(75, 23);
            this.btn_preview2.TabIndex = 7;
            this.btn_preview2.Text = "Preview";
            this.btn_preview2.UseVisualStyleBackColor = true;
            this.btn_preview2.Click += new System.EventHandler(this.btn_preview2_Click);
            // 
            // tbn_preview1
            // 
            this.tbn_preview1.Location = new System.Drawing.Point(8, 88);
            this.tbn_preview1.Name = "tbn_preview1";
            this.tbn_preview1.Size = new System.Drawing.Size(75, 23);
            this.tbn_preview1.TabIndex = 6;
            this.tbn_preview1.Text = "Preview";
            this.tbn_preview1.UseVisualStyleBackColor = true;
            this.tbn_preview1.Click += new System.EventHandler(this.tbn_preview1_Click);
            // 
            // btn_Capture2
            // 
            this.btn_Capture2.Location = new System.Drawing.Point(140, 59);
            this.btn_Capture2.Name = "btn_Capture2";
            this.btn_Capture2.Size = new System.Drawing.Size(75, 23);
            this.btn_Capture2.TabIndex = 5;
            this.btn_Capture2.Text = "Capture";
            this.btn_Capture2.UseVisualStyleBackColor = true;
            this.btn_Capture2.Click += new System.EventHandler(this.btn_Capture2_Click);
            // 
            // tb_fps2
            // 
            this.tb_fps2.Location = new System.Drawing.Point(140, 33);
            this.tb_fps2.Name = "tb_fps2";
            this.tb_fps2.Size = new System.Drawing.Size(100, 20);
            this.tb_fps2.TabIndex = 4;
            this.tb_fps2.Text = "30";
            // 
            // cb_camList2
            // 
            this.cb_camList2.FormattingEnabled = true;
            this.cb_camList2.Location = new System.Drawing.Point(140, 6);
            this.cb_camList2.Name = "cb_camList2";
            this.cb_camList2.Size = new System.Drawing.Size(121, 21);
            this.cb_camList2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Board);
            this.tabPage2.Controls.Add(this.btn_filter2);
            this.tabPage2.Controls.Add(this.btn_filter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Board
            // 
            this.btn_Board.Location = new System.Drawing.Point(99, 71);
            this.btn_Board.Name = "btn_Board";
            this.btn_Board.Size = new System.Drawing.Size(75, 23);
            this.btn_Board.TabIndex = 2;
            this.btn_Board.Text = "Show Board";
            this.btn_Board.UseVisualStyleBackColor = true;
            this.btn_Board.Click += new System.EventHandler(this.btn_Board_Click);
            // 
            // btn_filter2
            // 
            this.btn_filter2.Location = new System.Drawing.Point(148, 30);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(100, 23);
            this.btn_filter2.TabIndex = 1;
            this.btn_filter2.Text = "Cam2FilterProp";
            this.btn_filter2.UseVisualStyleBackColor = true;
            this.btn_filter2.Click += new System.EventHandler(this.btn_filter2_Click);
            // 
            // btn_filter1
            // 
            this.btn_filter1.Location = new System.Drawing.Point(29, 30);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(100, 23);
            this.btn_filter1.TabIndex = 0;
            this.btn_filter1.Text = "Cam1FilterProp";
            this.btn_filter1.UseVisualStyleBackColor = true;
            this.btn_filter1.Click += new System.EventHandler(this.btn_filter1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_orientation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_orientation
            // 
            this.btn_orientation.Location = new System.Drawing.Point(102, 99);
            this.btn_orientation.Name = "btn_orientation";
            this.btn_orientation.Size = new System.Drawing.Size(114, 23);
            this.btn_orientation.TabIndex = 0;
            this.btn_orientation.Text = "Orientation Settings";
            this.btn_orientation.UseVisualStyleBackColor = true;
            this.btn_orientation.Click += new System.EventHandler(this.btn_orientation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DBM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fps1;
        private System.Windows.Forms.ComboBox cb_camList1;
        private System.Windows.Forms.Button btn_Capture1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Capture2;
        private System.Windows.Forms.TextBox tb_fps2;
        private System.Windows.Forms.ComboBox cb_camList2;
        private System.Windows.Forms.Button btn_preview2;
        private System.Windows.Forms.Button tbn_preview1;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Board;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_orientation;
    }
}

