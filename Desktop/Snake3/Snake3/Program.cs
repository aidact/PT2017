using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static Boolean Game = true;
        static void Main(string[] args)
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 60;
            int screenWind = Console.WindowWidth;
            int screenHeigh = Console.WindowHeight;
            Console.CursorVisible = false;
            ConsoleKeyInfo btn;
            ConsoleKeyInfo last;
            Models.Snake snake = new Models.Snake();
            Models.Apple apple = new Models.Apple();
            Console.SetCursorPosition(17, 12);
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("ENTER ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("To Star Game!");
            last = Console.ReadKey();
            while (Game)
            {
                Models.Snake.draw();
                btn = Console.ReadKey();
                if (last.Key == ConsoleKey.UpArrow)
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.RightArrow:
                            Models.Snake.move(1, 0);
                            break;
                        case ConsoleKey.LeftArrow:
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.DownArrow)
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.DownArrow:
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.RightArrow:
                            Models.Snake.move(1, 0);
                            break;
                        case ConsoleKey.LeftArrow:
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.LeftArrow)
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.DownArrow:
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.LeftArrow:
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.RightArrow)
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.DownArrow:
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.RightArrow:
                            Models.Snake.move(1, 0);
                            break;
                    }
                }
                if (btn.Key == ConsoleKey.Escape)
                {
                    Game = false;
                }
                if (btn.Key == ConsoleKey.LeftArrow && last.Key != ConsoleKey.RightArrow)
                    last = btn;
                if (btn.Key == ConsoleKey.RightArrow && last.Key != ConsoleKey.LeftArrow)
                    last = btn;
                if (btn.Key == ConsoleKey.UpArrow && last.Key != ConsoleKey.DownArrow)
                    last = btn;
                if (btn.Key == ConsoleKey.DownArrow && last.Key != ConsoleKey.UpArrow)
                    last = btn;
            }
        }
    }
}