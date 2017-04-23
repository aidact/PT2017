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
        enum Direction
        {
            UP,
            DOWN,
            RIGHT,
            LEFT,
            NONE
        };
        Direction dir;

        Bitmap bmp;
        Ship s;
        Graphics g;
        Bullet b;
        SolidBrush brushW;
        SolidBrush brushY;
        SolidBrush brushR;
        SolidBrush brushG;

        public static bool BulIsEx = false;
        public static int bul = 0;
        Triangle tr1, tr2, tr3, tr4;
        public int x = 492, y = 325;

        public Form1()
        {
            InitializeComponent();

            dir = Direction.NONE;

            tr1 = new Triangle(180, 200);
            tr2 = new Triangle(220, 450);
            tr3 = new Triangle(800, 170);
            tr4 = new Triangle(610, 510);

            s = new Ship(x, y);
            b = new Bullet(492, 240);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\Aida\Desktop\fon.jpg");
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            brushW = new SolidBrush(Color.White);
            brushY = new SolidBrush(Color.Yellow);
            brushR = new SolidBrush(Color.Red);
            brushG = new SolidBrush(Color.Green);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) // если Enter, то происходит выстрел
            {
                BulIsEx = true; // пуля существует
                Refresh();
                pictureBox1.Image = bmp;
            }

            if (e.KeyCode == Keys.Up)
            {
                dir = Direction.UP;
            }
            if (e.KeyCode == Keys.Down)
            {
                dir = Direction.DOWN;
            }
            if (e.KeyCode == Keys.Right)
            {
                dir = Direction.RIGHT;
            }
            if (e.KeyCode == Keys.Left)
            {
                dir = Direction.LEFT;
            }
        }
        static int x1 = 180, x2 = 220, x3 = 800, x4 = 610;
        static int y1 = 200, y2 = 450, y3 = 170, y4 = 510;

        private void timer1_Tick(object sender, EventArgs e) // вверхний астероид слева
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\Aida\Desktop\fon.jpg");
            g = Graphics.FromImage(bmp);

            pictureBox1.Image = bmp;

            x1++; // asteroids
            y1++;
            if (x1 == 984)
                x1 = 0;
            if (y1 == 650)
                y1 = 0;
            x2++;
            y2--;
            if (x2 == 984)
                x2 = 0;
            if (y2 == 0)
                y2 = 650;
            x3--;
            y3++;
            if (x3 == 0)
                x3 = 984;
            if (y3 == 650)
                y3 = 0;
            x4--;
            y4--;
            if (x4 == 0)
                x4 = 984;
            if (y4 == 0)
                y4 = 650;

            tr1 = new Triangle(x1, y1);
            tr2 = new Triangle(x2, y2);
            tr3 = new Triangle(x3, y3);
            tr4 = new Triangle(x4, y4);

            if (BulIsEx) // bullet
            {
                bul += 4;
                b = new Bullet(380, 220 - bul);
            }

            if (dir == Direction.UP)
            {
                s = new Ship(x, y-=10);
            }
            if (dir == Direction.DOWN)
            {
                s = new Ship(x, y+=10);
            }
            if (dir == Direction.RIGHT)
            {
                s = new Ship(x+=10, y);
            }
            if (dir == Direction.LEFT)
            {
                s = new Ship(x-=10, y);
            }

            Paint1();

            pictureBox1.Image = bmp;
        }

        public void Paint1()
        {
            g.FillPath(brushR, tr1.path); // asteroids
            g.FillPath(brushR, tr1.path1);
            g.FillPath(brushR, tr2.path);
            g.FillPath(brushR, tr2.path1);
            g.FillPath(brushR, tr3.path);
            g.FillPath(brushR, tr3.path1);
            g.FillPath(brushR, tr4.path);
            g.FillPath(brushR, tr4.path1);

            g.FillEllipse(brushW, 100, 410, 25, 25); // snowballs
            g.FillEllipse(brushW, 350, 400, 25, 25);
            g.FillEllipse(brushW, 90, 150, 25, 25);
            g.FillEllipse(brushW, 330, 120, 25, 25);
            g.FillEllipse(brushW, 450, 170, 25, 25);
            g.FillEllipse(brushW, 600, 440, 25, 25);
            g.FillEllipse(brushW, 550, 310, 25, 25);
            g.FillEllipse(brushW, 640, 240, 25, 25);

            if (BulIsEx) // bullet
            {
                g.FillPath(brushG, b.path5);
            }

            g.FillPath(brushY, s.path3); // ship
            g.FillPath(brushG, s.path4); // arrow
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
