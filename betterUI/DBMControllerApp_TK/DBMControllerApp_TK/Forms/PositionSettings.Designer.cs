namespace DBMControllerApp_TK.Forms
{
    partial class PositionSettings
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
            this.ib_Preview = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_InvRight = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_InvLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.tb_Offset = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ib_Preview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 247);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ib_Preview
            // 
            this.ib_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ib_Preview.Location = new System.Drawing.Point(0, 0);
            this.ib_Preview.Margin = new System.Windows.Forms.Padding(0);
            this.ib_Preview.Name = "ib_Preview";
            this.ib_Preview.Size = new System.Drawing.Size(412, 213);
            this.ib_Preview.TabIndex = 2;
            this.ib_Preview.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Load, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_InvLeft, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Save, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_InvRight, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 213);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Load.Location = new System.Drawing.Point(276, 3);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(62, 28);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Load Saved";
            this.btn_Load.UseVisualStyleBackColor = false;
            // 
            // btn_InvRight
            // 
            this.btn_InvRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_InvRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InvRight.FlatAppearance.BorderSize = 0;
            this.btn_InvRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvRight.ForeColor = System.Drawing.Color.LightGray;
            this.btn_InvRight.Location = new System.Drawing.Point(208, 3);
            this.btn_InvRight.Name = "btn_InvRight";
            this.btn_InvRight.Size = new System.Drawing.Size(62, 28);
            this.btn_InvRight.TabIndex = 5;
            this.btn_InvRight.Text = "Invert Right";
            this.btn_InvRight.UseVisualStyleBackColor = false;
            this.btn_InvRight.Click += new System.EventHandler(this.btn_InvRight_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Save.Location = new System.Drawing.Point(344, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(65, 28);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_InvLeft
            // 
            this.btn_InvLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_InvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InvLeft.FlatAppearance.BorderSize = 0;
            this.btn_InvLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvLeft.ForeColor = System.Drawing.Color.LightGray;
            this.btn_InvLeft.Location = new System.Drawing.Point(140, 3);
            this.btn_InvLeft.Name = "btn_InvLeft";
            this.btn_InvLeft.Size = new System.Drawing.Size(62, 28);
            this.btn_InvLeft.TabIndex = 3;
            this.btn_InvLeft.Text = "Invert Left";
            this.btn_InvLeft.UseVisualStyleBackColor = false;
            this.btn_InvLeft.Click += new System.EventHandler(this.btn_InvLeft_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lbl_Position, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Offset, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(137, 34);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lbl_Position
            // 
            this.lbl_Position.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Position.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Position.Location = new System.Drawing.Point(3, 8);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(58, 17);
            this.lbl_Position.TabIndex = 8;
            this.lbl_Position.Text = "Position";
            // 
            // tb_Offset
            // 
            this.tb_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Offset.Location = new System.Drawing.Point(67, 7);
            this.tb_Offset.Name = "tb_Offset";
            this.tb_Offset.ReadOnly = true;
            this.tb_Offset.Size = new System.Drawing.Size(69, 20);
            this.tb_Offset.TabIndex = 7;
            // 
            // PositionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PositionSettings";
            this.Text = "PositionSettings";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Emgu.CV.UI.ImageBox ib_Preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_InvRight;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_InvLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox tb_Offset;
    }
}