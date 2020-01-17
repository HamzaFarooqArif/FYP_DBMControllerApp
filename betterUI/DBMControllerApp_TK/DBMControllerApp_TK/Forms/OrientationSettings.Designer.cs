namespace DBMControllerApp_TK.Forms
{
    partial class OrientationSettings
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
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Show3d = new System.Windows.Forms.Button();
            this.btn_Show2d = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_CurrentPressure = new System.Windows.Forms.TextBox();
            this.lbl_CurrentPressure = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_SerialList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_DataPacket = new System.Windows.Forms.Label();
            this.tb_DataPacket = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CurrentOrientation = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_OrientZ = new System.Windows.Forms.TextBox();
            this.lbl_OrientZ = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_OrientY = new System.Windows.Forms.TextBox();
            this.lbl_OrientY = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_OrientX = new System.Windows.Forms.TextBox();
            this.lbl_OrientX = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_OffZ = new System.Windows.Forms.NumericUpDown();
            this.tb_OffY = new System.Windows.Forms.NumericUpDown();
            this.tb_OffX = new System.Windows.Forms.NumericUpDown();
            this.lbl_OffZ = new System.Windows.Forms.Label();
            this.lbl_OffY = new System.Windows.Forms.Label();
            this.lbl_OffX = new System.Windows.Forms.Label();
            this.trk_OffX = new System.Windows.Forms.TrackBar();
            this.trk_OffY = new System.Windows.Forms.TrackBar();
            this.trk_OffZ = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_TipOffset = new System.Windows.Forms.TextBox();
            this.lbl_TipOffset = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffZ)).BeginInit();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.201058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.878307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.06349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84656F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.58201F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.btn_Show3d, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.btn_Show2d, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 337);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(269, 41);
            this.tableLayoutPanel14.TabIndex = 6;
            // 
            // btn_Show3d
            // 
            this.btn_Show3d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Show3d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Show3d.FlatAppearance.BorderSize = 0;
            this.btn_Show3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show3d.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Show3d.Location = new System.Drawing.Point(3, 3);
            this.btn_Show3d.Name = "btn_Show3d";
            this.btn_Show3d.Size = new System.Drawing.Size(128, 35);
            this.btn_Show3d.TabIndex = 6;
            this.btn_Show3d.Text = "Show 3d Orientation";
            this.btn_Show3d.UseVisualStyleBackColor = false;
            this.btn_Show3d.Click += new System.EventHandler(this.btn_Show3d_Click);
            // 
            // btn_Show2d
            // 
            this.btn_Show2d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Show2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Show2d.FlatAppearance.BorderSize = 0;
            this.btn_Show2d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show2d.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Show2d.Location = new System.Drawing.Point(137, 3);
            this.btn_Show2d.Name = "btn_Show2d";
            this.btn_Show2d.Size = new System.Drawing.Size(129, 35);
            this.btn_Show2d.TabIndex = 4;
            this.btn_Show2d.Text = "Show 2d Orientation";
            this.btn_Show2d.UseVisualStyleBackColor = false;
            this.btn_Show2d.Click += new System.EventHandler(this.btn_Show2d_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tb_CurrentPressure, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lbl_CurrentPressure, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 99);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(269, 42);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // tb_CurrentPressure
            // 
            this.tb_CurrentPressure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_CurrentPressure.Location = new System.Drawing.Point(81, 20);
            this.tb_CurrentPressure.Name = "tb_CurrentPressure";
            this.tb_CurrentPressure.ReadOnly = true;
            this.tb_CurrentPressure.Size = new System.Drawing.Size(107, 20);
            this.tb_CurrentPressure.TabIndex = 6;
            // 
            // lbl_CurrentPressure
            // 
            this.lbl_CurrentPressure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CurrentPressure.AutoSize = true;
            this.lbl_CurrentPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_CurrentPressure.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_CurrentPressure.Location = new System.Drawing.Point(76, 0);
            this.lbl_CurrentPressure.Name = "lbl_CurrentPressure";
            this.lbl_CurrentPressure.Size = new System.Drawing.Size(116, 17);
            this.lbl_CurrentPressure.TabIndex = 5;
            this.lbl_CurrentPressure.Text = "Current Pressure";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cb_SerialList, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cb_SerialList
            // 
            this.cb_SerialList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SerialList.FormattingEnabled = true;
            this.cb_SerialList.Location = new System.Drawing.Point(155, 6);
            this.cb_SerialList.Name = "cb_SerialList";
            this.cb_SerialList.Size = new System.Drawing.Size(111, 21);
            this.cb_SerialList.TabIndex = 5;
            this.cb_SerialList.SelectedIndexChanged += new System.EventHandler(this.cb_SerialList_SelectedIndexChanged);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.btn_Refresh, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.btn_Start, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(152, 34);
            this.tableLayoutPanel13.TabIndex = 6;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Refresh.Location = new System.Drawing.Point(79, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(70, 28);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Start.Location = new System.Drawing.Point(3, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(70, 28);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start Serial";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lbl_DataPacket, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_DataPacket, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 25);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbl_DataPacket
            // 
            this.lbl_DataPacket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataPacket.AutoSize = true;
            this.lbl_DataPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_DataPacket.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_DataPacket.Location = new System.Drawing.Point(3, 4);
            this.lbl_DataPacket.Name = "lbl_DataPacket";
            this.lbl_DataPacket.Size = new System.Drawing.Size(85, 17);
            this.lbl_DataPacket.TabIndex = 4;
            this.lbl_DataPacket.Text = "Data Packet";
            // 
            // tb_DataPacket
            // 
            this.tb_DataPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DataPacket.Location = new System.Drawing.Point(94, 3);
            this.tb_DataPacket.Name = "tb_DataPacket";
            this.tb_DataPacket.ReadOnly = true;
            this.tb_DataPacket.Size = new System.Drawing.Size(172, 20);
            this.tb_DataPacket.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_CurrentOrientation, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(269, 44);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbl_CurrentOrientation
            // 
            this.lbl_CurrentOrientation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CurrentOrientation.AutoSize = true;
            this.lbl_CurrentOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_CurrentOrientation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_CurrentOrientation.Location = new System.Drawing.Point(70, 0);
            this.lbl_CurrentOrientation.Name = "lbl_CurrentOrientation";
            this.lbl_CurrentOrientation.Size = new System.Drawing.Size(129, 17);
            this.lbl_CurrentOrientation.TabIndex = 5;
            this.lbl_CurrentOrientation.Text = "Current Orientation";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 17);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(269, 27);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.tb_OrientZ, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lbl_OrientZ, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(178, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(91, 32);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // tb_OrientZ
            // 
            this.tb_OrientZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OrientZ.Location = new System.Drawing.Point(26, 6);
            this.tb_OrientZ.Name = "tb_OrientZ";
            this.tb_OrientZ.ReadOnly = true;
            this.tb_OrientZ.Size = new System.Drawing.Size(63, 20);
            this.tb_OrientZ.TabIndex = 6;
            // 
            // lbl_OrientZ
            // 
            this.lbl_OrientZ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OrientZ.AutoSize = true;
            this.lbl_OrientZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OrientZ.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OrientZ.Location = new System.Drawing.Point(3, 7);
            this.lbl_OrientZ.Name = "lbl_OrientZ";
            this.lbl_OrientZ.Size = new System.Drawing.Size(17, 17);
            this.lbl_OrientZ.TabIndex = 5;
            this.lbl_OrientZ.Text = "Z";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.tb_OrientY, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_OrientY, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(89, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(89, 32);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tb_OrientY
            // 
            this.tb_OrientY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OrientY.Location = new System.Drawing.Point(26, 6);
            this.tb_OrientY.Name = "tb_OrientY";
            this.tb_OrientY.ReadOnly = true;
            this.tb_OrientY.Size = new System.Drawing.Size(63, 20);
            this.tb_OrientY.TabIndex = 6;
            // 
            // lbl_OrientY
            // 
            this.lbl_OrientY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OrientY.AutoSize = true;
            this.lbl_OrientY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OrientY.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OrientY.Location = new System.Drawing.Point(3, 7);
            this.lbl_OrientY.Name = "lbl_OrientY";
            this.lbl_OrientY.Size = new System.Drawing.Size(17, 17);
            this.lbl_OrientY.TabIndex = 5;
            this.lbl_OrientY.Text = "Y";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.tb_OrientX, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_OrientX, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(89, 32);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tb_OrientX
            // 
            this.tb_OrientX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OrientX.Location = new System.Drawing.Point(26, 6);
            this.tb_OrientX.Name = "tb_OrientX";
            this.tb_OrientX.ReadOnly = true;
            this.tb_OrientX.Size = new System.Drawing.Size(63, 20);
            this.tb_OrientX.TabIndex = 6;
            // 
            // lbl_OrientX
            // 
            this.lbl_OrientX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OrientX.AutoSize = true;
            this.lbl_OrientX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OrientX.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OrientX.Location = new System.Drawing.Point(3, 7);
            this.lbl_OrientX.Name = "lbl_OrientX";
            this.lbl_OrientX.Size = new System.Drawing.Size(17, 17);
            this.lbl_OrientX.TabIndex = 5;
            this.lbl_OrientX.Text = "X";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 141);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(269, 156);
            this.tableLayoutPanel10.TabIndex = 4;
            this.tableLayoutPanel10.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel10_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(92, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Apply Offset";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.Controls.Add(this.tb_OffZ, 2, 2);
            this.tableLayoutPanel11.Controls.Add(this.tb_OffY, 2, 1);
            this.tableLayoutPanel11.Controls.Add(this.tb_OffX, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.lbl_OffZ, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.lbl_OffY, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.lbl_OffX, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.trk_OffX, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.trk_OffY, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.trk_OffZ, 1, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(269, 119);
            this.tableLayoutPanel11.TabIndex = 7;
            // 
            // tb_OffZ
            // 
            this.tb_OffZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OffZ.Location = new System.Drawing.Point(221, 93);
            this.tb_OffZ.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OffZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.tb_OffZ.Name = "tb_OffZ";
            this.tb_OffZ.Size = new System.Drawing.Size(48, 20);
            this.tb_OffZ.TabIndex = 14;
            this.tb_OffZ.ValueChanged += new System.EventHandler(this.tb_OffZ_ValueChanged);
            // 
            // tb_OffY
            // 
            this.tb_OffY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OffY.Location = new System.Drawing.Point(221, 57);
            this.tb_OffY.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OffY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.tb_OffY.Name = "tb_OffY";
            this.tb_OffY.Size = new System.Drawing.Size(48, 20);
            this.tb_OffY.TabIndex = 13;
            this.tb_OffY.ValueChanged += new System.EventHandler(this.tb_OffY_ValueChanged);
            // 
            // tb_OffX
            // 
            this.tb_OffX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OffX.Location = new System.Drawing.Point(221, 13);
            this.tb_OffX.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OffX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.tb_OffX.Name = "tb_OffX";
            this.tb_OffX.Size = new System.Drawing.Size(48, 20);
            this.tb_OffX.TabIndex = 12;
            this.tb_OffX.ValueChanged += new System.EventHandler(this.tb_OffX_ValueChanged);
            // 
            // lbl_OffZ
            // 
            this.lbl_OffZ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OffZ.AutoSize = true;
            this.lbl_OffZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OffZ.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OffZ.Location = new System.Drawing.Point(3, 95);
            this.lbl_OffZ.Name = "lbl_OffZ";
            this.lbl_OffZ.Size = new System.Drawing.Size(17, 17);
            this.lbl_OffZ.TabIndex = 8;
            this.lbl_OffZ.Text = "Z";
            // 
            // lbl_OffY
            // 
            this.lbl_OffY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OffY.AutoSize = true;
            this.lbl_OffY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OffY.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OffY.Location = new System.Drawing.Point(3, 59);
            this.lbl_OffY.Name = "lbl_OffY";
            this.lbl_OffY.Size = new System.Drawing.Size(17, 17);
            this.lbl_OffY.TabIndex = 7;
            this.lbl_OffY.Text = "Y";
            // 
            // lbl_OffX
            // 
            this.lbl_OffX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_OffX.AutoSize = true;
            this.lbl_OffX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_OffX.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_OffX.Location = new System.Drawing.Point(3, 15);
            this.lbl_OffX.Name = "lbl_OffX";
            this.lbl_OffX.Size = new System.Drawing.Size(17, 17);
            this.lbl_OffX.TabIndex = 6;
            this.lbl_OffX.Text = "X";
            // 
            // trk_OffX
            // 
            this.trk_OffX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trk_OffX.Location = new System.Drawing.Point(23, 0);
            this.trk_OffX.Margin = new System.Windows.Forms.Padding(0);
            this.trk_OffX.Maximum = 360;
            this.trk_OffX.Name = "trk_OffX";
            this.trk_OffX.Size = new System.Drawing.Size(198, 47);
            this.trk_OffX.TabIndex = 9;
            this.trk_OffX.ValueChanged += new System.EventHandler(this.trk_OffX_ValueChanged);
            // 
            // trk_OffY
            // 
            this.trk_OffY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trk_OffY.Location = new System.Drawing.Point(23, 47);
            this.trk_OffY.Margin = new System.Windows.Forms.Padding(0);
            this.trk_OffY.Maximum = 360;
            this.trk_OffY.Name = "trk_OffY";
            this.trk_OffY.Size = new System.Drawing.Size(198, 41);
            this.trk_OffY.TabIndex = 10;
            this.trk_OffY.ValueChanged += new System.EventHandler(this.trk_OffY_ValueChanged);
            // 
            // trk_OffZ
            // 
            this.trk_OffZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trk_OffZ.Location = new System.Drawing.Point(23, 88);
            this.trk_OffZ.Margin = new System.Windows.Forms.Padding(0);
            this.trk_OffZ.Maximum = 360;
            this.trk_OffZ.Name = "trk_OffZ";
            this.trk_OffZ.Size = new System.Drawing.Size(198, 31);
            this.trk_OffZ.TabIndex = 11;
            this.trk_OffZ.ValueChanged += new System.EventHandler(this.trk_OffZ_ValueChanged);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.tb_TipOffset, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.lbl_TipOffset, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(269, 20);
            this.tableLayoutPanel15.TabIndex = 8;
            // 
            // tb_TipOffset
            // 
            this.tb_TipOffset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_TipOffset.Location = new System.Drawing.Point(137, 3);
            this.tb_TipOffset.Name = "tb_TipOffset";
            this.tb_TipOffset.ReadOnly = true;
            this.tb_TipOffset.Size = new System.Drawing.Size(107, 20);
            this.tb_TipOffset.TabIndex = 8;
            // 
            // lbl_TipOffset
            // 
            this.lbl_TipOffset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TipOffset.AutoSize = true;
            this.lbl_TipOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_TipOffset.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_TipOffset.Location = new System.Drawing.Point(61, 1);
            this.lbl_TipOffset.Name = "lbl_TipOffset";
            this.lbl_TipOffset.Size = new System.Drawing.Size(70, 17);
            this.lbl_TipOffset.TabIndex = 7;
            this.lbl_TipOffset.Text = "Tip Offset";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.btn_Load, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btn_Save, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 297);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(269, 40);
            this.tableLayoutPanel12.TabIndex = 5;
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
            this.btn_Load.Size = new System.Drawing.Size(128, 34);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Load Saved";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Save.Location = new System.Drawing.Point(137, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(129, 34);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // OrientationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(269, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrientationSettings";
            this.Text = "OrientationSettings";
            this.Load += new System.EventHandler(this.OrientationSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_OffX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_OffZ)).EndInit();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_SerialList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_DataPacket;
        private System.Windows.Forms.TextBox tb_DataPacket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox tb_CurrentPressure;
        private System.Windows.Forms.Label lbl_CurrentPressure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_CurrentOrientation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox tb_OrientZ;
        private System.Windows.Forms.Label lbl_OrientZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox tb_OrientY;
        private System.Windows.Forms.Label lbl_OrientY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox tb_OrientX;
        private System.Windows.Forms.Label lbl_OrientX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label lbl_OffZ;
        private System.Windows.Forms.Label lbl_OffY;
        private System.Windows.Forms.Label lbl_OffX;
        private System.Windows.Forms.TrackBar trk_OffX;
        private System.Windows.Forms.TrackBar trk_OffY;
        private System.Windows.Forms.TrackBar trk_OffZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown tb_OffZ;
        private System.Windows.Forms.NumericUpDown tb_OffY;
        private System.Windows.Forms.NumericUpDown tb_OffX;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button btn_Show3d;
        private System.Windows.Forms.Button btn_Show2d;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TextBox tb_TipOffset;
        private System.Windows.Forms.Label lbl_TipOffset;
    }
}