using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialComm
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            this.rtbAboutUs.Rtf = @"{\rtf1 {\colortbl;\red0\green0\blue0;\red0\green0\blue255;}\b \cf2 Global Software Talent\b0 \cf1 \par Class: \b HCM.UIT_ICT13_EMBEDDED_HCM16_027\b0 \par Project: \b Device control via bluetooth\b0 \par \par Team: \cf2\b BLELT_UIT\b0\cf1 \par ________ \b Member 1\b0 ________ \par Name: Le Khanh Linh \par Student ID: 13520449 \par ________ \b Member 2\b0 ________ \par Name: Nguyen Manh Thao \par Student ID: 14520853}";
            this.rtbAboutUs.SelectAll();
            this.rtbAboutUs.SelectionAlignment = HorizontalAlignment.Center;
            this.rtbAboutUs.Select(0, 0);
        }

        private void btnOK_AboutUs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
