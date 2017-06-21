using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static Boolean Game = true; // создаем функцию game
        static void Main(string[] args)
        {
            Console.WindowHeight = 25; // задаем высоту рамки
            Console.WindowWidth = 80;// задаем ширину рамки
            int screenWind = Console.WindowWidth; // приравниваем размер ширины 
            int screenHeigh = Console.WindowHeight; // приравниваем размер высоты
            Console.CursorVisible = false; // делаем курсор невидимым
            ConsoleKeyInfo btn;
            ConsoleKeyInfo last;
            Models.Snake snake = new Models.Snake(); 
            Models.Apple apple = new Models.Apple();
            Console.SetCursorPosition(28, 12); //задаем позицию для фразы
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("ENTER ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("To Start Game!");
            last = Console.ReadKey(); // прочитываем если пользователь нажал кнопку для начала игры
            while (Game) // пока игра продолжается
            {              
                Models.Snake.draw(); // прорисовываем змейку
                btn = Console.ReadKey(); // прочитываем какую кнопку нажал пользователь
                if (last.Key == ConsoleKey.UpArrow)// если вверх
                {
                    switch (btn.Key) // создаем положительные случаи
                    {
                        case ConsoleKey.UpArrow: // идти вверх
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.RightArrow: // идти вправо
                            Models.Snake.move(1, 0);
                            break;
                        case ConsoleKey.LeftArrow: // идти влево
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.DownArrow) // если вниз
                {
                    switch (btn.Key) // случаи
                    {
                        case ConsoleKey.DownArrow: // вниз
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.RightArrow: // вправо
                            Models.Snake.move(1, 0);
                            break;
                        case ConsoleKey.LeftArrow: // влево
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.LeftArrow) // если влево
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow: // вверх
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.DownArrow: // вниз
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.LeftArrow: // влево
                            Models.Snake.move(-1, 0);
                            break;
                    }
                }
                else if (last.Key == ConsoleKey.RightArrow) // если вправо
                {
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow: // вверх
                            Models.Snake.move(0, -1);
                            break;
                        case ConsoleKey.DownArrow: // вниз
                            Models.Snake.move(0, 1);
                            break;
                        case ConsoleKey.RightArrow: // вправо
                            Models.Snake.move(1, 0);
                            break;
                    }
                }
                if (btn.Key == ConsoleKey.Escape) // если нажато escape
                {
                    Game = false; // конец игры, закрытие консоли
                }
                if (btn.Key == ConsoleKey.LeftArrow && last.Key != ConsoleKey.RightArrow) // невозможные случаи
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