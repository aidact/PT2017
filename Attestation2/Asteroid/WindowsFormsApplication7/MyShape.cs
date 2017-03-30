using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    class Triangle
    {
        public GraphicsPath path = new GraphicsPath();
        public GraphicsPath path1 = new GraphicsPath();
        public Triangle(int x, int y)
        {
             int p = Convert.ToInt32(Math.Sqrt(3)/2)*40;
            path.AddLine(x + 200 , y + 200 , x + 180, y + 200 +p ); // треуг смотр вниз
            path.AddLine(x + 180 , y + 200+p , x + 220, y + 200 +p);
            path.AddLine(x + 220, y + 200 + p, x + 200 , y + 200);

            int r = Convert.ToInt32(5 / 3 * p );
            path1.AddLine(x + 200, y + 210 + r, x + 180, y + 210 - p + r ); // треуг смотр вверх
            path1.AddLine(x + 180, y + 210 - p + r, x + 220, y + 210 - p + r );
            path1.AddLine(x + 220, y + 210 - p + r , x + 200, y + 210 + r );
            
        }
    }
}
