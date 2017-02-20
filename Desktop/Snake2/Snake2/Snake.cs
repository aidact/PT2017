using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Snake
    {
        public static int x1; // создаем позиции по высоте
        public static int y1; // создаем позиции по ширине
        public static List<Point> body;
        public static ConsoleColor color;
        public static char sign;
        public static int cnt = 1;

        public Snake()
        {
            body = new List<Point>(); //
            body.Add(new Point(28, 9)); // задаем первоначальное положение змейки
            body.Add(new Point(28, 10)); // по середине консоли
            body.Add(new Point(28, 11));
            color = ConsoleColor.Yellow; // тело змейки желтое
            sign = 'o'; // обозначаем змейку буквой 'о'
        }

        public static void move(int _x, int _y)
        {
            x1 = body[body.Count - 1].x;
            y1 = body[body.Count - 1].y;
            
            
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x; // при движении последнее положение тела змейки становится предпоследним
                body[i].y = body[i - 1].y;
            }
            body[0].x += _x; // голову змейки приравниваем позициям курсора
            body[0].y += _y;
        }

        public static void draw()
        {
            Console.Clear(); // каждый раз очищаем консоль

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(61, 9);
            Console.Write("current score:");
            Console.Write(cnt);

            if(body[0].x < 1) // если змейка вышла за границы то ее возращают на противополжную сторону
            {
                body[0].x = 58;
            } else if (body[0].x > 58)
            {
                body[0].x = 1;
            }

            if(body[0].y > 23)
            {
                body[0].y = 1;
            } else if (body[0].y < 1)
            {
                body[0].y = 23;
            }

            for (int i = 6; i <= 17; i++) // положения стен по y
            {
                if (body[0].x == 19 && body[0].y == i) // если положение головы змеи совпадает с положением первой стены
                {
                    Console.SetCursorPosition(30,11); // положение фразы
                    Console.Write("GAME OVER!!");
                    Console.SetCursorPosition(29, 12);
                    Console.Write("Your score: ");
                    Console.Write(cnt);
                    Console.SetCursorPosition(29, 13);
                    Console.Write("Press any key");
                    Program.Game = false; // конец игры
                    return;
                }
                if (body[0].x == 38 && body[0].y == i) // вторая стена
                {
                    Console.SetCursorPosition(30, 11);
                    Console.Write("GAME OVER!!");
                    Console.SetCursorPosition(29, 12);
                    Console.Write("Your score: ");
                    Console.Write(cnt);
                    Console.SetCursorPosition(29, 13);
                    Console.Write("Press any key");
                    Program.Game = false; // конец игры
                    return;
                }
            }
            
            for (int i = 1; i < body.Count; i++)
            {
                if(body[0].x == body[i].x && body[0].y == body[i].y) // если положение головы змейки равно одному из положений ее тела
                {
                    Console.SetCursorPosition(30, 11);
                    Console.Write("GAME OVER!!");
                    Console.SetCursorPosition(29, 12);
                    Console.Write("Your score: ");
                    Console.Write(cnt);
                    Console.SetCursorPosition(29, 13);
                    Console.Write("Press any key");
                    Program.Game = false; // конец игры
                    return;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.Write(sign);

            if (body[0].x == Models.Apple.a.x && body[0].y == Models.Apple.a.y) // если положение головы змейки совподает с положением яблока
            {
                body.Add(new Point(x1, y1)); // увеличиваем змейку
                cnt++;
                Models.Apple.appear(); // повляется новое яболко
            } else
            {
                Console.ForegroundColor = Models.Apple.color; // выводим цвет яблок
                Console.SetCursorPosition(Apple.a.x, Apple.a.y);
                Console.Write(Models.Apple.sign); // выводим знак обозначения яблок
            }

            Console.ForegroundColor = Models.Snake.color; // цвет змейки
            for (int i = 1; i < body.Count; i++) // просматриваем места где она находится
            {
                Console.SetCursorPosition(body[i].x, body[i].y); // по этим местам
                Console.Write(sign); // прорисовываем змейку
            }

            Console.ForegroundColor = ConsoleColor.Red; // цвет красный
            Border.border(); // для всех границ и стен
        }
    }
}
