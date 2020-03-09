using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace EEE424
{
    public partial class frmClass : Form
    {
        frmMain frmMainT;
        public frmClass(frmMain frmM)
        {
            InitializeComponent();
            frmMainT = frmM;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            frmMainT.lblClass.Text = txtBoxClass.Text;
            frmMainT.grpBox1.Visible = true;

            // write in a file...
            TextWriter tw = new StreamWriter("LevelTerm.txt");
            tw.WriteLine(txtBoxClass.Text);
            tw.Close();

            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {

        }
    }
}
