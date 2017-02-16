using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Wall wall = new Wall();
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (pressedKey.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (pressedKey.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (pressedKey.Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
                snake.Draw();
                wall.Draw();
            }
        }
    }
}
