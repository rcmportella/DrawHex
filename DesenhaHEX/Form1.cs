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
            // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.Red);

            flagGraphics.Clear(Color.Transparent);
            Point point1 = new Point(31, 0);
            Point point2 = new Point(95, 0);
            Point point3 = new Point(127, 55);
            Point point4 = new Point(95, 110);
            Point point5 = new Point(31, 110);
            Point point6 = new Point(0, 55);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };

            // Draw polygon to screen.
            flagGraphics.FillPolygon(redBrush, curvePoints);
            flag.Save("hexagon.png", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image = flag;
        }
    }
}
