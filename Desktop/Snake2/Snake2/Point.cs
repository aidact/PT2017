using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Point
    {
        public int x; // положения по ширине
        public int y; // положения по высоте

        public Point() { }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}