using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;


namespace Exercise2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            cmdPrint.Visible = false;


            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = new PrintDocument();
            ppd.Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);

            ppd.ShowDialog();
            cmdPrint.Visible = true;
        }

        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bt = new Bitmap(this.Width, this.Height);

            /*
            // Determine Scaling
            float scale = 1.0f;
            scale = Math.Min(scale, (float)e.MarginBounds.Width / bt.Width);
            scale = Math.Min(scale, (float)e.MarginBounds.Height / bt.Height);

            e.Graphics.TranslateTransform(e.MarginBounds.Left +
                (e.MarginBounds.Width - bt.Width * scale) / 2, e.MarginBounds.Top);
            e.Graphics.ScaleTransform(scale, scale);
            //------------------------------------------------
            */

            DrawToBitmap(bt, new Rectangle(0, 0, this.Width, this.Height));
            RectangleF destinationRect = new RectangleF(0, 0, this.Width, this.Height);

            //Draw a portion of the image. Scale that portion of the image
            RectangleF sourceRect = new RectangleF(0, 0, this.Width, this.Height);
            e.Graphics.DrawImage(bt, destinationRect, sourceRect, GraphicsUnit.Pixel);

        }
    }
}
