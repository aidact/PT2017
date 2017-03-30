using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    class Bullet
    {
        public GraphicsPath path5 = new GraphicsPath();
        public Bullet(int x, int y)
        {
            path5.AddLine(x + 110, y + 60, x + 112, y + 70);
            path5.AddLine(x + 112, y + 70, x + 121, y + 72);
            path5.AddLine(x + 121, y + 72, x + 112, y + 74);
            path5.AddLine(x + 112, y + 74, x + 110, y + 83);
            path5.AddLine(x + 110, y + 83, x + 108, y + 74);
            path5.AddLine(x + 108, y + 74, x + 100, y + 72);
            path5.AddLine(x + 100, y + 72, x + 108, y + 70);
            path5.AddLine(x + 108, y + 70, x + 110, y + 60);
        }
    }
}
