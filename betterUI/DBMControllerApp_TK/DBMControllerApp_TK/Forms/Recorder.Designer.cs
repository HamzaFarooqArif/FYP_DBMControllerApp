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
            this.btn_StartRecord = new System.Windows.Forms.Button();
            this.btn_PlayPause = new System.Windows.Forms.Button();
            this.btn_StartPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.trk_thickness = new System.Windows.Forms.TrackBar();
            this.lbl_Thickness = new System.Windows.Forms.Label();
            this.tb_Thickness = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_OffX = new System.Windows.Forms.NumericUpDown();
            this.lbl_Resolution = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.rtb_Color = new System.Windows.Forms.RichTextBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.tb_Position = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trk_Seek = new System.Windows.Forms.TrackBar();
            this.tb_Seek = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_duster = new System.Windows.Forms.Button();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ib_Preview = new Emgu.CV.UI.ImageBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Thickness)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_StartRecord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_PlayPause, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_StartPlay, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 333);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 28);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btn_StartRecord.Size = new System.Drawing.Size(167, 22);
            this.btn_StartRecord.TabIndex = 7;
            this.btn_StartRecord.Text = "Start Recording";
            this.btn_StartRecord.UseVisualStyleBackColor = false;
            this.btn_StartRecord.Click += new System.EventHandler(this.btn_StartRecord_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_PlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayPause.ForeColor = System.Drawing.Color.LightGray;
            this.btn_PlayPause.Location = new System.Drawing.Point(349, 3);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(167, 22);
            this.btn_PlayPause.TabIndex = 8;
            this.btn_PlayPause.Text = "Pause";
            this.btn_PlayPause.UseVisualStyleBackColor = false;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayPause_Click);
            // 
            // btn_StartPlay
            // 
            this.btn_StartPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_StartPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartPlay.FlatAppearance.BorderSize = 0;
            this.btn_StartPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartPlay.ForeColor = System.Drawing.Color.LightGray;
            this.btn_StartPlay.Location = new System.Drawing.Point(176, 3);
            this.btn_StartPlay.Name = "btn_StartPlay";
            this.btn_StartPlay.Size = new System.Drawing.Size(167, 22);
            this.btn_StartPlay.TabIndex = 9;
            this.btn_StartPlay.Text = "Start Playing";
            this.btn_StartPlay.UseVisualStyleBackColor = false;
            this.btn_StartPlay.Click += new System.EventHandler(this.btn_StartPlay_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ib_Preview, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(519, 482);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btn_Save, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Load, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 454);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(519, 28);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Save.Location = new System.Drawing.Point(262, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(254, 22);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Load.Location = new System.Drawing.Point(3, 3);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(253, 22);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load Saved";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.trk_thickness, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_Thickness, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tb_Thickness, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 392);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(513, 30);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // trk_thickness
            // 
            this.trk_thickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trk_thickness.Location = new System.Drawing.Point(81, 3);
            this.trk_thickness.Maximum = 100;
            this.trk_thickness.Minimum = 1;
            this.trk_thickness.Name = "trk_thickness";
            this.trk_thickness.Size = new System.Drawing.Size(338, 24);
            this.trk_thickness.TabIndex = 8;
            this.trk_thickness.Value = 1;
            this.trk_thickness.ValueChanged += new System.EventHandler(this.trk_thickness_ValueChanged);
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
            // tb_Thickness
            // 
            this.tb_Thickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Thickness.Location = new System.Drawing.Point(422, 5);
            this.tb_Thickness.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Thickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_Thickness.Name = "tb_Thickness";
            this.tb_Thickness.Size = new System.Drawing.Size(91, 20);
            this.tb_Thickness.TabIndex = 16;
            this.tb_Thickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_Thickness.ValueChanged += new System.EventHandler(this.tb_Thickness_ValueChanged);
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 425);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(519, 29);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // tb_OffX
            // 
            this.tb_OffX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OffX.Location = new System.Drawing.Point(143, 4);
            this.tb_OffX.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OffX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tb_OffX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_OffX.Name = "tb_OffX";
            this.tb_OffX.Size = new System.Drawing.Size(91, 20);
            this.tb_OffX.TabIndex = 15;
            this.tb_OffX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_OffX.ValueChanged += new System.EventHandler(this.tb_OffX_ValueChanged);
            // 
            // lbl_Resolution
            // 
            this.lbl_Resolution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Resolution.AutoSize = true;
            this.lbl_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Resolution.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Resolution.Location = new System.Drawing.Point(3, 6);
            this.lbl_Resolution.Name = "lbl_Resolution";
            this.lbl_Resolution.Size = new System.Drawing.Size(137, 17);
            this.lbl_Resolution.TabIndex = 14;
            this.lbl_Resolution.Text = "Tick Resolution (ms)";
            // 
            // lbl_Color
            // 
            this.lbl_Color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Color.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Color.Location = new System.Drawing.Point(237, 6);
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
            this.rtb_Color.Click += new System.EventHandler(this.rtb_Color_Click);
            // 
            // lbl_Position
            // 
            this.lbl_Position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Position.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Position.Location = new System.Drawing.Point(374, 6);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(58, 17);
            this.lbl_Position.TabIndex = 12;
            this.lbl_Position.Text = "Position";
            // 
            // tb_Position
            // 
            this.tb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Position.Location = new System.Drawing.Point(438, 4);
            this.tb_Position.Name = "tb_Position";
            this.tb_Position.ReadOnly = true;
            this.tb_Position.Size = new System.Drawing.Size(78, 20);
            this.tb_Position.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.trk_Seek, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Seek, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 293);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // trk_Seek
            // 
            this.trk_Seek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trk_Seek.Location = new System.Drawing.Point(3, 3);
            this.trk_Seek.Name = "trk_Seek";
            this.trk_Seek.Size = new System.Drawing.Size(436, 34);
            this.trk_Seek.TabIndex = 0;
            // 
            // tb_Seek
            // 
            this.tb_Seek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Seek.Location = new System.Drawing.Point(445, 10);
            this.tb_Seek.Name = "tb_Seek";
            this.tb_Seek.ReadOnly = true;
            this.tb_Seek.Size = new System.Drawing.Size(71, 20);
            this.tb_Seek.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81564F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.27747F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel4.Controls.Add(this.btn_duster, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_SaveFile, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_LoadFile, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Enable, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 361);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(519, 28);
            this.tableLayoutPanel4.TabIndex = 3;
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
            this.btn_duster.Size = new System.Drawing.Size(98, 22);
            this.btn_duster.TabIndex = 8;
            this.btn_duster.Text = "Duster";
            this.btn_duster.UseVisualStyleBackColor = false;
            this.btn_duster.Click += new System.EventHandler(this.btn_duster_Click);
            // 
            // btn_Enable
            // 
            this.btn_Enable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Enable.FlatAppearance.BorderSize = 0;
            this.btn_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enable.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Enable.Location = new System.Drawing.Point(211, 3);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(105, 22);
            this.btn_Enable.TabIndex = 9;
            this.btn_Enable.Text = "Enable Device Input";
            this.btn_Enable.UseVisualStyleBackColor = false;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(107, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ib_Preview
            // 
            this.ib_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ib_Preview.Location = new System.Drawing.Point(0, 0);
            this.ib_Preview.Margin = new System.Windows.Forms.Padding(0);
            this.ib_Preview.Name = "ib_Preview";
            this.ib_Preview.Size = new System.Drawing.Size(519, 293);
            this.ib_Preview.TabIndex = 2;
            this.ib_Preview.TabStop = false;
            this.ib_Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ib_Preview_MouseDown);
            this.ib_Preview.MouseEnter += new System.EventHandler(this.ib_Preview_MouseEnter);
            this.ib_Preview.MouseLeave += new System.EventHandler(this.ib_Preview_MouseLeave);
            this.ib_Preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ib_Preview_MouseMove);
            this.ib_Preview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ib_Preview_MouseUp);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_SaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SaveFile.FlatAppearance.BorderSize = 0;
            this.btn_SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveFile.ForeColor = System.Drawing.Color.LightGray;
            this.btn_SaveFile.Location = new System.Drawing.Point(322, 3);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(91, 22);
            this.btn_SaveFile.TabIndex = 11;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_LoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LoadFile.FlatAppearance.BorderSize = 0;
            this.btn_LoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFile.ForeColor = System.Drawing.Color.LightGray;
            this.btn_LoadFile.Location = new System.Drawing.Point(419, 3);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(97, 22);
            this.btn_LoadFile.TabIndex = 12;
            this.btn_LoadFile.Text = "Load File";
            this.btn_LoadFile.UseVisualStyleBackColor = false;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Lecture file|*.dbm";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Lecture file|*.dbm";
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(519, 482);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recorder";
            this.Text = "Recorder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Thickness)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Seek)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_StartPlay;
        private System.Windows.Forms.Button btn_PlayPause;
        private System.Windows.Forms.Button btn_StartRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.Button btn_duster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar trk_Seek;
        private System.Windows.Forms.TextBox tb_Seek;
        private System.Windows.Forms.TrackBar trk_thickness;
        private System.Windows.Forms.Label lbl_Thickness;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.RichTextBox rtb_Color;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox tb_Position;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Emgu.CV.UI.ImageBox ib_Preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_Resolution;
        private System.Windows.Forms.NumericUpDown tb_OffX;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.NumericUpDown tb_Thickness;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}