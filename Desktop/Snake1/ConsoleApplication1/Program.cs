using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Program
    {
       public static Boolean ok = true;
       public static Food food = new Food();
       public static Snake snake = new Snake();
       public static Wall wall = new Wall();
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 25);
            Console.CursorVisible = false;
                 
            while (ok)
            {
                snake.Draw();
                wall.Draw();
                food.Draw();
                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (pressed.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (pressed.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (pressed.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (pressed.Key == ConsoleKey.Escape)
                    break;
                if(pressed.Key == ConsoleKey.F2)
                {
                   
                        snake.Save();
                        wall.Save();
                        food.Save();
                 
                }
                if(pressed.Key == ConsoleKey.F3)
                {
                  
                        snake.Resume();
                        wall.Resume();
                        food.Resume();
                  
                }
                Console.Clear();
                
            }
            
        }
    }
}
