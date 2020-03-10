using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Exercise1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(drawing);
        }
        private void drawing(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4);
            AdjustableArrowCap noArrow = new AdjustableArrowCap(0, 0);

            Pen p = new Pen(Color.Blue, 5);
            Pen q = new Pen(Color.Blue, 1);

            p.CustomEndCap = bigArrow;
            q.CustomEndCap = noArrow;

            e.Graphics.DrawLine(p, 10, 10, 60, 10);
            e.Graphics.DrawLine(q, 10, 40, 60, 40);

            e.Graphics.DrawRectangle(p, 60, 60, 50, 50);
            e.Graphics.DrawEllipse(q, 200, 80, 50, 50);
        }
    }
}
