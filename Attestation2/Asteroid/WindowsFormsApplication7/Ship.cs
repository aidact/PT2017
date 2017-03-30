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
        public GraphicsPath path4 = new GraphicsPath(); // пушка
        public Ship(int x, int y)
        {
            path3.AddLine(x + 100, y + 80, x + 141, y + 100); // вверхняя точка
            path3.AddLine(x + 141, y + 100, x + 141, y + 140); // вправо-вверх
            path3.AddLine(x + 141, y + 140, x + 100, y + 160); // вправо-вниз
            path3.AddLine(x + 100, y + 160, x + 60, y + 140); // нижняя точка
            path3.AddLine(x + 60, y + 140, x + 60, y + 100); // влево-вниз
            path3.AddLine(x + 60, y + 100, x + 100, y + 80); // влево-вверх

            path4.AddLine(x + 100, y + 100, x + 110, y + 120);
            path4.AddLine(x + 110, y + 120, x + 105, y + 120);
            path4.AddLine(x + 105, y + 120, x + 105, y + 135);
            path4.AddLine(x + 105, y + 135, x + 95, y + 135);
            path4.AddLine(x + 95, y + 135, x + 95, y + 120);
            path4.AddLine(x + 95, y + 120, x + 90, y + 120);
            path4.AddLine(x + 90, y + 120, x + 100, y + 100);
        }
    }
}
