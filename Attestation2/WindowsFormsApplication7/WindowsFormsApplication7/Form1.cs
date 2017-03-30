using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public int x1, y1, x2, y2, w, h;
        public Form1()
        {
            InitializeComponent();
            x1 = 10;
            y1 = 100;
            w = 20;
            h = 20;

            x2 = 0;
            y2 = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue), x1, y1, w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = int.Parse(textBox1.Text);
            y1 = int.Parse(textBox2.Text);
            x2 = int.Parse(textBox3.Text);
            y2 = int.Parse(textBox4.Text);
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 += 5;
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
