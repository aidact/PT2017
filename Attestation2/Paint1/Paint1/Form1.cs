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
        Color curCol;

        Queue<Point> q;
       
        public Form1()
        {
            InitializeComponent();
            paint = new Paint();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;

            q = new Queue<Point>();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.mouseClicked = true;
            paint.prevpoint = e.Location;

            if (paint.shape == Paint1.Paint.Shape.FILL)
            {
                q.Enqueue(e.Location);
                originCol = bmp.GetPixel(e.Location.X, e.Location.Y);
                curCol = paint.pen.Color;

                
                while (q.Count > 0) // add in the queue
                {
                    Point curPoint = q.Dequeue();
                    Step(curPoint.X+1, curPoint.Y);
                    Step(curPoint.X-1, curPoint.Y);
                    Step(curPoint.X, curPoint.Y+1);
                    Step(curPoint.X, curPoint.Y-1);
                }
                pictureBox1.Refresh();
            }

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

        public void Step(int x, int y)
        {
            if (x < 0) return;
            if (y < 0) return;
            if (x >= bmp.Width) return;
            if (y >= bmp.Height) return;
            if (bmp.GetPixel(x, y) != originCol) return;
            bmp.SetPixel(x, y, curCol);
            q.Enqueue(new Point(x, y));
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

        private void trackBar1_Scroll(object sender, EventArgs e) // width of the figure
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

        private void button9_Click(object sender, EventArgs e) // save
        {
            paint.shape = Paint1.Paint.Shape.FILL;
        }

        private void button10_Click(object sender, EventArgs e) // load
        {
            pictureBox1.Image.Save("image");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //pictureBox1.Load("image");
            bmp = new Bitmap("image");
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
