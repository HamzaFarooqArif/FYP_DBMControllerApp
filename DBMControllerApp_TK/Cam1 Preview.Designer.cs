namespace DBMControllerApp_TK
{
    partial class Cam1_Preview
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
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(606, 450);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            this.imageBox1.DoubleClick += new System.EventHandler(this.imageBox1_DoubleClick);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(444, 468);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(75, 23);
            this.btn_Undo.TabIndex = 3;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(525, 468);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save Settings";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(12, 468);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Show Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // Cam1_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 495);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.imageBox1);
            this.Name = "Cam1_Preview";
            this.Text = "Cam1_Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cam1_Preview_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_filter;
    }
}