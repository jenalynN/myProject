using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

using System.Drawing.Imaging;

using System.Drawing.Printing;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.listViewPrinter1.PrintPreview();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 500, 800);
            printPreviewDialog1.Size = new System.Drawing.Size(500, 800);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Bitmap bitmap = new System.Drawing.Bitmap(listview1.Width, listview1.Height);
            //listview1.DrawToBitmap(bitmap, listview1.ClientRectangle);
            //e.Graphics.DrawImage(bitmap, new Point(50, 50));
            
            int ii = 1;
            int startX, startY, Offset;
            int total = 0;
            startX = startY = 50;
                Offset = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                // Not sure what/why these two are here 
                startX += i;
                startY += ii++;

                // Draw the row details for ? receipt 
                e.Graphics.DrawString(" " + listView1.Items[i].SubItems[0].Text + "\t" +
                    listView1.Items[i].SubItems[1].Text + "\t" +
                    listView1.Items[i].SubItems[2].Text
                  , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);

                // Move the next print position 'down the page' ie, y axis increases from top to bottom
                 Offset = Offset + 20;

                 total += int.Parse(listView1.Items[i].SubItems[2].Text.ToString());

            }
            e.Graphics.DrawString(" \tTotal:\t" +
                    total + "\t", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);
        }


    }
}
