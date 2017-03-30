using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Triangle shape1, shape2, shape3, shape4;
        Ship s;
        Graphics g;
        Bullet b;
        SolidBrush brush;
        SolidBrush brush1;
        SolidBrush brush2;
        SolidBrush brush3;
        public Form1()
        {
            InitializeComponent();
            shape1 = new Triangle(0, -20);
            shape2 = new Triangle(90, 150);
            shape3 = new Triangle(300, 180);
            shape4 = new Triangle(400, -40);
            s = new Ship(300, 150);
            b = new Bullet(310, 140);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\Aida\Desktop\Image\fon.jpg");
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            brush = new SolidBrush(Color.White);
            brush1 = new SolidBrush(Color.Yellow);
            brush2 = new SolidBrush(Color.Red);
            brush3 = new SolidBrush(Color.Green);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.DrawPath(new Pen(Color.Red), shape1.path);
            g.FillPath(brush2, shape1.path);
            //g.DrawPath(new Pen(Color.Red), shape1.path1);
            g.FillPath(brush2, shape1.path1);
            //g.DrawPath(new Pen(Color.Red), shape2.path);
            g.FillPath(brush2, shape2.path);
            //g.DrawPath(new Pen(Color.Red), shape2.path1);
            g.FillPath(brush2, shape2.path1);
            //g.DrawPath(new Pen(Color.Red), shape3.path);
            g.FillPath(brush2, shape3.path);
            //g.DrawPath(new Pen(Color.Red), shape3.path1);
            g.FillPath(brush2, shape3.path1);
            //g.DrawPath(new Pen(Color.Red), shape4.path);
            g.FillPath(brush2, shape4.path);
            //g.DrawPath(new Pen(Color.Red), shape4.path1);
            g.FillPath(brush2, shape4.path1);

            //g.DrawEllipse(new Pen(Color.White), 100, 410, 20, 20);
            g.FillEllipse(brush, 100, 410, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 350, 400, 20, 20);
            g.FillEllipse(brush, 350, 400, 25, 25);           
            //g.DrawEllipse(new Pen(Color.White), 90, 150, 20, 20);
            g.FillEllipse(brush, 90, 150, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 330, 120, 20, 20);
            g.FillEllipse(brush, 330, 120, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 450, 170, 20, 20);
            g.FillEllipse(brush, 450, 170, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 600, 440, 20, 20);
            g.FillEllipse(brush, 600, 440, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 550, 310, 20, 20);
            g.FillEllipse(brush, 550, 310, 25, 25);
            //g.DrawEllipse(new Pen(Color.White), 640, 240, 20, 20);
            g.FillEllipse(brush, 640, 240, 25, 25);

            g.DrawPath(new Pen(Color.Yellow), s.path3); // ship
            g.FillPath(brush1, s.path3);
            g.DrawPath(new Pen(Color.Green), s.path4); // gun
            g.FillPath(brush3, s.path4);

            g.DrawPath(new Pen(Color.Green), b.path5); // bullet
            g.FillPath(brush3, b.path5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
