using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    class Apple
    {
        public static Point a = new Point();
        public static char sign;
        public static ConsoleColor color;
        public static Random rand = new Random();
        public static Boolean ok;

        public Apple()
        {
            do
            {
                ok = true;
                a.x = rand.Next(2, 58); // положение яблока в любой точке по ширине
                a.y = rand.Next(2, 23); // положение яблока в любой точке по высоте
                for (int i = 0; i < Snake.body.Count; i++) 
                {
                    if (a.x == Snake.body[i].x && a.y == Snake.body[i].y) // если положение тела змейки равно положению яблока
                    {
                        ok = false; // то это неверно, значит игра продолжается
                    }
                }
                if (a.x == 19 || a.x == 38 && a.y > 5 && a.y < 18)
                {
                    ok = false;
                }
            } while (!ok);
            color = ConsoleColor.Green; // цвет яблока зеленый
            sign = '*'; // обозначение яблока
        }

        public static void appear()
        {
            do
            {
                ok = true; // пока условие того, что змейка съела яблоко верно
                a.x = rand.Next(2, 58); // выбираем любую позицию по ширине
                a.y = rand.Next(2, 23); // по высоте
                for (int i = 0; i < Snake.body.Count; i++)
                {
                    if (a.x == Snake.body[i].x && a.y == Snake.body[i].y)
                    {
                        ok = false;
                    }
                }
                if (a.x == 19 || a.x == 38 && a.y > 5 && a.y < 18)
                {
                    ok = false;
                }
            } while (!ok);
        }
    }
}
