namespace DBMControllerApp_TK.Forms
{
    partial class CameraSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_camList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFps = new System.Windows.Forms.Label();
            this.tb_fps = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CameraIndex = new System.Windows.Forms.Label();
            this.btn_Capture = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_CameraIndex, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_camList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 124);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cb_camList
            // 
            this.cb_camList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_camList.FormattingEnabled = true;
            this.cb_camList.Location = new System.Drawing.Point(3, 36);
            this.cb_camList.Name = "cb_camList";
            this.cb_camList.Size = new System.Drawing.Size(204, 21);
            this.cb_camList.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblFps, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_fps, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 31);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblFps
            // 
            this.lblFps.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFps.AutoSize = true;
            this.lblFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFps.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFps.Location = new System.Drawing.Point(3, 7);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(34, 17);
            this.lblFps.TabIndex = 0;
            this.lblFps.Text = "FPS";
            // 
            // tb_fps
            // 
            this.tb_fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_fps.Location = new System.Drawing.Point(43, 5);
            this.tb_fps.Name = "tb_fps";
            this.tb_fps.Size = new System.Drawing.Size(164, 20);
            this.tb_fps.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Preview, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Capture, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 93);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(210, 31);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lbl_CameraIndex
            // 
            this.lbl_CameraIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CameraIndex.AutoSize = true;
            this.lbl_CameraIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_CameraIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_CameraIndex.Location = new System.Drawing.Point(76, 7);
            this.lbl_CameraIndex.Name = "lbl_CameraIndex";
            this.lbl_CameraIndex.Size = new System.Drawing.Size(57, 17);
            this.lbl_CameraIndex.TabIndex = 3;
            this.lbl_CameraIndex.Text = "Camera";
            // 
            // btn_Capture
            // 
            this.btn_Capture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Capture.FlatAppearance.BorderSize = 0;
            this.btn_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Capture.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Capture.Location = new System.Drawing.Point(3, 3);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(99, 25);
            this.btn_Capture.TabIndex = 2;
            this.btn_Capture.Text = "Capture";
            this.btn_Capture.UseVisualStyleBackColor = false;
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Preview.FlatAppearance.BorderSize = 0;
            this.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preview.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Preview.Location = new System.Drawing.Point(108, 3);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(99, 25);
            this.btn_Preview.TabIndex = 3;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = false;
            // 
            // CameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(210, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CameraSettings";
            this.Text = "Camera Settings";
            this.Load += new System.EventHandler(this.CameraSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_camList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.TextBox tb_fps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_CameraIndex;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Capture;
    }
}