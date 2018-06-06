using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesenhaHEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap flag = new Bitmap(128, 111);
            Graphics flagGraphics = Graphics.FromImage(flag);
            /*
            int red = 0;
            int white = 11;
            while (white <= 100)
            {
                flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
                flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
                red += 20;
                white += 20;
            }
            */
            flagGraphics.Clear(Color.Transparent);
            Point pt1 = new Point(31, 0);
            Point pt2 = new Point(95, 0);
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            pt1 = pt2;
            pt2.X = 127;
            pt2.Y = 55;
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            pt1 = pt2;
            pt2.X = 95;
            pt2.Y = 110;
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            pt1 = pt2;
            pt2.X = 31;
            pt2.Y = 110;
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            pt1 = pt2;
            pt2.X = 0;
            pt2.Y = 55;
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            pt1 = pt2;
            pt2.X = 31;
            pt2.Y = 0;
            flagGraphics.DrawLine(new Pen(Brushes.Red), pt1, pt2);
            flag.Save("hexagon.png", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image = flag;
        }
    }
}
