using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gPic;
        Graphics g;
        public static Paint paint;

        Color originCol;
        Color curCol = paint.pen.Color;
       
        public Form1()
        {
            InitializeComponent();
            paint = new Paint();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.mouseClicked = true;
            paint.prevpoint = e.Location;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint.Draw1(g, e.Location);
            paint.mouseClicked = false;
            pictureBox1.Refresh();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint.mouseClicked)
            {
                pictureBox1.Refresh();
                paint.Draw(g, e.Location);
                paint.Draw1(pictureBox1.CreateGraphics(), e.Location);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paint.pen.Color = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint.pen.Color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint.pen.Color = Color.DeepSkyBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paint.pen.Color = Color.Yellow;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            paint.pen.Width = trackBar1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paint.shape = Paint1.Paint.Shape.RECTANGLE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paint.shape = Paint1.Paint.Shape.LINE;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paint.shape = Paint1.Paint.Shape.PEN;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            paint.shape = Paint1.Paint.Shape.ELLIPSE;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            paint.shape = Paint1.Paint.Shape.FILL;
        }
    }
}
