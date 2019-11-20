namespace DBMControllerApp_TK
{
    partial class Cam_FilterProp
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
            this.trk_HueU = new System.Windows.Forms.TrackBar();
            this.trk_SatU = new System.Windows.Forms.TrackBar();
            this.trk_ValU = new System.Windows.Forms.TrackBar();
            this.tb_HueU = new System.Windows.Forms.TextBox();
            this.tb_SatU = new System.Windows.Forms.TextBox();
            this.tb_ValU = new System.Windows.Forms.TextBox();
            this.rtb_U = new System.Windows.Forms.RichTextBox();
            this.trk_HueL = new System.Windows.Forms.TrackBar();
            this.trk_SatL = new System.Windows.Forms.TrackBar();
            this.trk_ValL = new System.Windows.Forms.TrackBar();
            this.tb_HueL = new System.Windows.Forms.TextBox();
            this.tb_SatL = new System.Windows.Forms.TextBox();
            this.tb_ValL = new System.Windows.Forms.TextBox();
            this.rtb_L = new System.Windows.Forms.RichTextBox();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trk_HueU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_SatU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ValU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_HueL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_SatL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ValL)).BeginInit();
            this.SuspendLayout();
            // 
            // trk_HueU
            // 
            this.trk_HueU.Location = new System.Drawing.Point(12, 12);
            this.trk_HueU.Maximum = 255;
            this.trk_HueU.Name = "trk_HueU";
            this.trk_HueU.Size = new System.Drawing.Size(104, 45);
            this.trk_HueU.TabIndex = 0;
            this.trk_HueU.ValueChanged += new System.EventHandler(this.trk_HueU_ValueChanged);
            // 
            // trk_SatU
            // 
            this.trk_SatU.Location = new System.Drawing.Point(12, 52);
            this.trk_SatU.Maximum = 255;
            this.trk_SatU.Name = "trk_SatU";
            this.trk_SatU.Size = new System.Drawing.Size(104, 45);
            this.trk_SatU.TabIndex = 1;
            this.trk_SatU.ValueChanged += new System.EventHandler(this.trk_SatU_ValueChanged);
            // 
            // trk_ValU
            // 
            this.trk_ValU.Location = new System.Drawing.Point(12, 92);
            this.trk_ValU.Maximum = 255;
            this.trk_ValU.Name = "trk_ValU";
            this.trk_ValU.Size = new System.Drawing.Size(104, 45);
            this.trk_ValU.TabIndex = 2;
            this.trk_ValU.ValueChanged += new System.EventHandler(this.trk_ValU_ValueChanged);
            // 
            // tb_HueU
            // 
            this.tb_HueU.Location = new System.Drawing.Point(122, 12);
            this.tb_HueU.Name = "tb_HueU";
            this.tb_HueU.Size = new System.Drawing.Size(42, 20);
            this.tb_HueU.TabIndex = 3;
            this.tb_HueU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_HueU_KeyDown);
            // 
            // tb_SatU
            // 
            this.tb_SatU.Location = new System.Drawing.Point(122, 52);
            this.tb_SatU.Name = "tb_SatU";
            this.tb_SatU.Size = new System.Drawing.Size(42, 20);
            this.tb_SatU.TabIndex = 4;
            this.tb_SatU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SatU_KeyDown);
            // 
            // tb_ValU
            // 
            this.tb_ValU.Location = new System.Drawing.Point(122, 92);
            this.tb_ValU.Name = "tb_ValU";
            this.tb_ValU.Size = new System.Drawing.Size(42, 20);
            this.tb_ValU.TabIndex = 5;
            this.tb_ValU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ValU_KeyDown);
            // 
            // rtb_U
            // 
            this.rtb_U.Location = new System.Drawing.Point(170, 16);
            this.rtb_U.Name = "rtb_U";
            this.rtb_U.Size = new System.Drawing.Size(100, 96);
            this.rtb_U.TabIndex = 6;
            this.rtb_U.Text = "";
            // 
            // trk_HueL
            // 
            this.trk_HueL.Location = new System.Drawing.Point(12, 143);
            this.trk_HueL.Maximum = 255;
            this.trk_HueL.Name = "trk_HueL";
            this.trk_HueL.Size = new System.Drawing.Size(104, 45);
            this.trk_HueL.TabIndex = 7;
            this.trk_HueL.ValueChanged += new System.EventHandler(this.trk_HueL_ValueChanged);
            // 
            // trk_SatL
            // 
            this.trk_SatL.Location = new System.Drawing.Point(12, 182);
            this.trk_SatL.Maximum = 255;
            this.trk_SatL.Name = "trk_SatL";
            this.trk_SatL.Size = new System.Drawing.Size(104, 45);
            this.trk_SatL.TabIndex = 8;
            this.trk_SatL.ValueChanged += new System.EventHandler(this.trk_SatL_ValueChanged);
            // 
            // trk_ValL
            // 
            this.trk_ValL.Location = new System.Drawing.Point(11, 224);
            this.trk_ValL.Maximum = 255;
            this.trk_ValL.Name = "trk_ValL";
            this.trk_ValL.Size = new System.Drawing.Size(104, 45);
            this.trk_ValL.TabIndex = 9;
            this.trk_ValL.ValueChanged += new System.EventHandler(this.trk_ValL_ValueChanged);
            // 
            // tb_HueL
            // 
            this.tb_HueL.Location = new System.Drawing.Point(122, 143);
            this.tb_HueL.Name = "tb_HueL";
            this.tb_HueL.Size = new System.Drawing.Size(42, 20);
            this.tb_HueL.TabIndex = 10;
            this.tb_HueL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_HueL_KeyDown);
            // 
            // tb_SatL
            // 
            this.tb_SatL.Location = new System.Drawing.Point(121, 182);
            this.tb_SatL.Name = "tb_SatL";
            this.tb_SatL.Size = new System.Drawing.Size(42, 20);
            this.tb_SatL.TabIndex = 11;
            this.tb_SatL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SatL_KeyDown);
            // 
            // tb_ValL
            // 
            this.tb_ValL.Location = new System.Drawing.Point(122, 224);
            this.tb_ValL.Name = "tb_ValL";
            this.tb_ValL.Size = new System.Drawing.Size(42, 20);
            this.tb_ValL.TabIndex = 12;
            this.tb_ValL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ValL_KeyDown);
            // 
            // rtb_L
            // 
            this.rtb_L.Location = new System.Drawing.Point(170, 148);
            this.rtb_L.Name = "rtb_L";
            this.rtb_L.Size = new System.Drawing.Size(100, 96);
            this.rtb_L.TabIndex = 13;
            this.rtb_L.Text = "";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Location = new System.Drawing.Point(135, 275);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(73, 13);
            this.lbl_Heading.TabIndex = 14;
            this.lbl_Heading.Text = "Form Heading";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(290, 314);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(97, 23);
            this.btn_SaveSettings.TabIndex = 15;
            this.btn_SaveSettings.Text = "Save Settings";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // Cam_FilterProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 349);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.rtb_L);
            this.Controls.Add(this.tb_ValL);
            this.Controls.Add(this.tb_SatL);
            this.Controls.Add(this.tb_HueL);
            this.Controls.Add(this.trk_ValL);
            this.Controls.Add(this.trk_SatL);
            this.Controls.Add(this.trk_HueL);
            this.Controls.Add(this.rtb_U);
            this.Controls.Add(this.tb_ValU);
            this.Controls.Add(this.tb_SatU);
            this.Controls.Add(this.tb_HueU);
            this.Controls.Add(this.trk_ValU);
            this.Controls.Add(this.trk_SatU);
            this.Controls.Add(this.trk_HueU);
            this.Name = "Cam_FilterProp";
            this.Text = "Cam_FilterProp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cam_FilterProp_FormClosing);
            this.Load += new System.EventHandler(this.Cam1_FilterProp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trk_HueU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_SatU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ValU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_HueL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_SatL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ValL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trk_HueU;
        private System.Windows.Forms.TrackBar trk_SatU;
        private System.Windows.Forms.TrackBar trk_ValU;
        private System.Windows.Forms.TextBox tb_HueU;
        private System.Windows.Forms.TextBox tb_SatU;
        private System.Windows.Forms.TextBox tb_ValU;
        private System.Windows.Forms.RichTextBox rtb_U;
        private System.Windows.Forms.TrackBar trk_HueL;
        private System.Windows.Forms.TrackBar trk_SatL;
        private System.Windows.Forms.TrackBar trk_ValL;
        private System.Windows.Forms.TextBox tb_HueL;
        private System.Windows.Forms.TextBox tb_SatL;
        private System.Windows.Forms.TextBox tb_ValL;
        private System.Windows.Forms.RichTextBox rtb_L;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.Button btn_SaveSettings;
    }
}