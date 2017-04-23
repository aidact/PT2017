using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    class Ship
    {
        public GraphicsPath path3 = new GraphicsPath(); // корабль
        public GraphicsPath path4 = new GraphicsPath(); // стрелка

        public Ship(int x, int y)
        {
            Point[] polypoints =
            {
                new Point(x,y-30),
                new Point(x+30,y-15),
                new Point(x+30,y+15),
                new Point(x,y+30),
                new Point(x-30,y+15),
                new Point(x-30,y-15)
            };
            Point[] polypoints1 =
            {
                new Point(x,y-5),
                new Point(x+10,y+5),
                new Point(x-10,y+5),
                
            };

            path3.AddPolygon(polypoints);
            path4.AddPolygon(polypoints1);
        }
    }
}
