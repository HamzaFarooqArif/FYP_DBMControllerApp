namespace DBMControllerApp_TK.Forms
{
    partial class Recorder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.btn_StartRecord = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Thickness = new System.Windows.Forms.TextBox();
            this.trk_thickness = new System.Windows.Forms.TrackBar();
            this.lbl_Thickness = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.rtb_Color = new System.Windows.Forms.RichTextBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.tb_Position = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trk_Seek = new System.Windows.Forms.TrackBar();
            this.txt_Seek = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.btn_duster = new System.Windows.Forms.Button();
            this.btn_Marker = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.lbl_Resolution = new System.Windows.Forms.Label();
            this.tb_OffX = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_PlayPause, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_StartRecord, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 359);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(361, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_PlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.ForeColor = System.Drawing.Color.LightGray;
            this.btn_PlayPause.Location = new System.Drawing.Point(182, 3);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(173, 23);
            this.btn_PlayPause.TabIndex = 8;
            this.btn_PlayPause.Text = "Play";
            this.btn_PlayPause.UseVisualStyleBackColor = false;
            // 
            // btn_StartRecord
            // 
            this.btn_StartRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_StartRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartRecord.FlatAppearance.BorderSize = 0;
            this.btn_StartRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartRecord.ForeColor = System.Drawing.Color.LightGray;
            this.btn_StartRecord.Location = new System.Drawing.Point(3, 3);
            this.btn_StartRecord.Name = "btn_StartRecord";
            this.btn_StartRecord.Size = new System.Drawing.Size(173, 23);
            this.btn_StartRecord.TabIndex = 7;
            this.btn_StartRecord.Text = "Start Recording";
            this.btn_StartRecord.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.imageBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(537, 482);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.tb_Thickness, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.trk_thickness, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_Thickness, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 422);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(531, 29);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tb_Thickness
            // 
            this.tb_Thickness.Location = new System.Drawing.Point(466, 3);
            this.tb_Thickness.Name = "tb_Thickness";
            this.tb_Thickness.Size = new System.Drawing.Size(62, 20);
            this.tb_Thickness.TabIndex = 9;
            // 
            // trk_thickness
            // 
            this.trk_thickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trk_thickness.Location = new System.Drawing.Point(81, 3);
            this.trk_thickness.Maximum = 320;
            this.trk_thickness.Minimum = 1;
            this.trk_thickness.Name = "trk_thickness";
            this.trk_thickness.Size = new System.Drawing.Size(379, 23);
            this.trk_thickness.TabIndex = 8;
            this.trk_thickness.Value = 1;
            // 
            // lbl_Thickness
            // 
            this.lbl_Thickness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Thickness.AutoSize = true;
            this.lbl_Thickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Thickness.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Thickness.Location = new System.Drawing.Point(3, 6);
            this.lbl_Thickness.Name = "lbl_Thickness";
            this.lbl_Thickness.Size = new System.Drawing.Size(72, 17);
            this.lbl_Thickness.TabIndex = 7;
            this.lbl_Thickness.Text = "Thickness";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.3705F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.6295F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.tb_OffX, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Resolution, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Color, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.rtb_Color, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Position, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.tb_Position, 5, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 454);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(537, 28);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // lbl_Color
            // 
            this.lbl_Color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Color.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Color.Location = new System.Drawing.Point(237, 5);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(41, 17);
            this.lbl_Color.TabIndex = 10;
            this.lbl_Color.Text = "Color";
            // 
            // rtb_Color
            // 
            this.rtb_Color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtb_Color.Location = new System.Drawing.Point(284, 4);
            this.rtb_Color.Name = "rtb_Color";
            this.rtb_Color.Size = new System.Drawing.Size(20, 20);
            this.rtb_Color.TabIndex = 11;
            this.rtb_Color.Text = "";
            // 
            // lbl_Position
            // 
            this.lbl_Position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Position.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Position.Location = new System.Drawing.Point(401, 5);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(58, 17);
            this.lbl_Position.TabIndex = 12;
            this.lbl_Position.Text = "Position";
            // 
            // tb_Position
            // 
            this.tb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Position.Location = new System.Drawing.Point(465, 4);
            this.tb_Position.Name = "tb_Position";
            this.tb_Position.Size = new System.Drawing.Size(69, 20);
            this.tb_Position.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.trk_Seek, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_Seek, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 319);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // trk_Seek
            // 
            this.trk_Seek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trk_Seek.Location = new System.Drawing.Point(3, 3);
            this.trk_Seek.Name = "trk_Seek";
            this.trk_Seek.Size = new System.Drawing.Size(454, 34);
            this.trk_Seek.TabIndex = 0;
            // 
            // txt_Seek
            // 
            this.txt_Seek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Seek.Location = new System.Drawing.Point(463, 10);
            this.txt_Seek.Name = "txt_Seek";
            this.txt_Seek.Size = new System.Drawing.Size(71, 20);
            this.txt_Seek.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Enable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_duster, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Marker, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 388);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(537, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(271, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Enable
            // 
            this.btn_Enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Enable.FlatAppearance.BorderSize = 0;
            this.btn_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enable.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Enable.Location = new System.Drawing.Point(354, 3);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(180, 25);
            this.btn_Enable.TabIndex = 9;
            this.btn_Enable.Text = "Enable Device Input";
            this.btn_Enable.UseVisualStyleBackColor = false;
            // 
            // btn_duster
            // 
            this.btn_duster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_duster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_duster.FlatAppearance.BorderSize = 0;
            this.btn_duster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duster.ForeColor = System.Drawing.Color.LightGray;
            this.btn_duster.Location = new System.Drawing.Point(3, 3);
            this.btn_duster.Name = "btn_duster";
            this.btn_duster.Size = new System.Drawing.Size(128, 25);
            this.btn_duster.TabIndex = 8;
            this.btn_duster.Text = "Duster";
            this.btn_duster.UseVisualStyleBackColor = false;
            // 
            // btn_Marker
            // 
            this.btn_Marker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Marker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Marker.FlatAppearance.BorderSize = 0;
            this.btn_Marker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Marker.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Marker.Location = new System.Drawing.Point(137, 3);
            this.btn_Marker.Name = "btn_Marker";
            this.btn_Marker.Size = new System.Drawing.Size(128, 25);
            this.btn_Marker.TabIndex = 7;
            this.btn_Marker.Text = "Marker";
            this.btn_Marker.UseVisualStyleBackColor = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(537, 319);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // lbl_Resolution
            // 
            this.lbl_Resolution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Resolution.AutoSize = true;
            this.lbl_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Resolution.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Resolution.Location = new System.Drawing.Point(3, 5);
            this.lbl_Resolution.Name = "lbl_Resolution";
            this.lbl_Resolution.Size = new System.Drawing.Size(137, 17);
            this.lbl_Resolution.TabIndex = 14;
            this.lbl_Resolution.Text = "Tick Resolution (ms)";
            // 
            // tb_OffX
            // 
            this.tb_OffX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OffX.Location = new System.Drawing.Point(143, 4);
            this.tb_OffX.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OffX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.tb_OffX.Name = "tb_OffX";
            this.tb_OffX.Size = new System.Drawing.Size(91, 20);
            this.tb_OffX.TabIndex = 15;
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(537, 482);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recorder";
            this.Text = "Recorder";
            this.Load += new System.EventHandler(this.Recorder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.Button btn_StartRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.Button btn_duster;
        private System.Windows.Forms.Button btn_Marker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar trk_Seek;
        private System.Windows.Forms.TextBox txt_Seek;
        private System.Windows.Forms.TrackBar trk_thickness;
        private System.Windows.Forms.Label lbl_Thickness;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.RichTextBox rtb_Color;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox tb_Thickness;
        private System.Windows.Forms.TextBox tb_Position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_Resolution;
        private System.Windows.Forms.NumericUpDown tb_OffX;
    }
}