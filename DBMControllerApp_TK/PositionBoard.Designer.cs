namespace DBMControllerApp_TK
{
    partial class PositionBoard
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
            this.btn_InvLeft = new System.Windows.Forms.Button();
            this.btn_InvRight = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(480, 320);
            this.imageBox1.TabIndex = 3;
            this.imageBox1.TabStop = false;
            // 
            // btn_InvLeft
            // 
            this.btn_InvLeft.Location = new System.Drawing.Point(12, 338);
            this.btn_InvLeft.Name = "btn_InvLeft";
            this.btn_InvLeft.Size = new System.Drawing.Size(75, 23);
            this.btn_InvLeft.TabIndex = 4;
            this.btn_InvLeft.Text = "Invert Left";
            this.btn_InvLeft.UseVisualStyleBackColor = true;
            this.btn_InvLeft.Click += new System.EventHandler(this.btn_InvLeft_Click);
            // 
            // btn_InvRight
            // 
            this.btn_InvRight.Location = new System.Drawing.Point(417, 338);
            this.btn_InvRight.Name = "btn_InvRight";
            this.btn_InvRight.Size = new System.Drawing.Size(75, 23);
            this.btn_InvRight.TabIndex = 5;
            this.btn_InvRight.Text = "Invert Right";
            this.btn_InvRight.UseVisualStyleBackColor = true;
            this.btn_InvRight.Click += new System.EventHandler(this.btn_InvRight_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(406, 367);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Settings";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // PositionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 404);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_InvRight);
            this.Controls.Add(this.btn_InvLeft);
            this.Controls.Add(this.imageBox1);
            this.Name = "PositionBoard";
            this.Text = "PositionBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_InvLeft;
        private System.Windows.Forms.Button btn_InvRight;
        private System.Windows.Forms.Button btn_save;
    }
}