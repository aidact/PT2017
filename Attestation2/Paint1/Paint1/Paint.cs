using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Paint1
{
   
    public class Paint
    {
        public enum Shape
        {
            LINE,
            PEN,
            RECTANGLE,
            ELLIPSE,
            ERAZER,
            FILL
        };
        public Shape shape;
        public Pen pen;
        public Point prevpoint;
        public bool mouseClicked = false;

       public Paint()
        {
            pen = new Pen (Color.Black);
            prevpoint = new Point(0, 0);
            shape = Shape.PEN;

        }

       public void Draw(Graphics g, Point curPoint)
       {
               if (shape == Shape.PEN)
               {
                   g.DrawLine(pen, prevpoint, curPoint);
                   prevpoint = curPoint;
               }
       }
       public void Draw1(Graphics gPic, Point curPoint)
       {
           if (mouseClicked)
           {
               if (shape == Shape.LINE)
               {
                   gPic.DrawLine(pen, prevpoint, curPoint);
               }
               if (shape == Shape.RECTANGLE)
               {
                   int w = Math.Abs(prevpoint.X - curPoint.X);
                   int h = Math.Abs(prevpoint.Y - curPoint.Y);
                   int minX = Math.Min(prevpoint.X, curPoint.X);
                   int minY = Math.Min(prevpoint.Y, curPoint.Y);

                   gPic.DrawRectangle(pen, minX, minY, w, h);
               }
               if (shape == Shape.ELLIPSE)
               {
                   int w = Math.Abs(prevpoint.X - curPoint.X);
                   int h = Math.Abs(prevpoint.Y - curPoint.Y);
                   int minX = Math.Min(prevpoint.X, curPoint.X);
                   int minY = Math.Min(prevpoint.Y, curPoint.Y);

                   gPic.DrawEllipse(pen, minX, minY, w, h);
               }
           }
       }
    }
}
