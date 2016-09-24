namespace SerialComm
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.ptbAboutUs = new System.Windows.Forms.PictureBox();
            this.rtbAboutUs = new System.Windows.Forms.RichTextBox();
            this.btnOK_AboutUs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAboutUs)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAboutUs
            // 
            this.ptbAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("ptbAboutUs.Image")));
            this.ptbAboutUs.Location = new System.Drawing.Point(138, 12);
            this.ptbAboutUs.Name = "ptbAboutUs";
            this.ptbAboutUs.Size = new System.Drawing.Size(125, 83);
            this.ptbAboutUs.TabIndex = 0;
            this.ptbAboutUs.TabStop = false;
            // 
            // rtbAboutUs
            // 
            this.rtbAboutUs.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbAboutUs.Location = new System.Drawing.Point(12, 108);
            this.rtbAboutUs.Name = "rtbAboutUs";
            this.rtbAboutUs.ReadOnly = true;
            this.rtbAboutUs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAboutUs.Size = new System.Drawing.Size(376, 151);
            this.rtbAboutUs.TabIndex = 1;
            this.rtbAboutUs.Text = "";
            // 
            // btnOK_AboutUs
            // 
            this.btnOK_AboutUs.Location = new System.Drawing.Point(163, 265);
            this.btnOK_AboutUs.Name = "btnOK_AboutUs";
            this.btnOK_AboutUs.Size = new System.Drawing.Size(75, 23);
            this.btnOK_AboutUs.TabIndex = 2;
            this.btnOK_AboutUs.Text = "OK";
            this.btnOK_AboutUs.Click += new System.EventHandler(this.btnOK_AboutUs_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK_AboutUs);
            this.Controls.Add(this.rtbAboutUs);
            this.Controls.Add(this.ptbAboutUs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbAboutUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAboutUs;
        private System.Windows.Forms.RichTextBox rtbAboutUs;
        private DevExpress.XtraEditors.SimpleButton btnOK_AboutUs;
    }
}