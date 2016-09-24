namespace SerialComm
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.ptbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLoading
            // 
            this.ptbLoading.Image = ((System.Drawing.Image)(resources.GetObject("ptbLoading.Image")));
            this.ptbLoading.Location = new System.Drawing.Point(703, 503);
            this.ptbLoading.Name = "ptbLoading";
            this.ptbLoading.Size = new System.Drawing.Size(35, 35);
            this.ptbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLoading.TabIndex = 0;
            this.ptbLoading.TabStop = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.ControlBox = false;
            this.Controls.Add(this.ptbLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLoading;
    }
}