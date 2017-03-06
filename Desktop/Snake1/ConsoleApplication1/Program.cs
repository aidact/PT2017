using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Serializable]
   class Program
    {
       public static Boolean ok = true;
       public static Food food = new Food();
       public static Snake snake = new Snake();
       public static Wall wall;
       public static int d = 0;
       public static int i = 0;

       static void Move()
       {
             
              while (ok)
              {
                  wall = new Wall(i);
                  
                  /*Console.SetCursorPosition(52, 12);
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("current score: ");
                  Console.ForegroundColor = ConsoleColor.White;
                  Console.Write(snake.cnt);*/

                  
                  if (d == 1)
                      snake.Move(0, -1); // up
                  if (d == 2)
                      snake.Move(0, 1); // down
                  if(d == 3)
                      snake.Move(1, 0); // right
                  if(d == 4)
                      snake.Move(-1, 0); // left
                  
                  snake.Draw();
                  wall.Draw();
                  food.Draw();

                  Thread.Sleep(90);
              }
              if (Snake.body.Count == 2)
              {
                  for (int j = Snake.body.Count() - 1; j >= 0; j--)
                  {
                      Console.SetCursorPosition(Snake.body[j].x, Snake.body[j].y);
                      Console.Write(' ');
                  }
                  
                  snake = new Snake();
                  i++;
                  
                  wall = new Wall(i);
                  
                  
              }
              /*if (food.FoodnWall(wall))
              {
                  while (food.FoodnWall(wall))
                      Food.SetRandomPosition();
              }
              if (food.FoodnBody(snake))
              {
                  while (food.FoodnBody(snake))
                      Food.SetRandomPosition();
              }*/
              
       }
        static void Main(string[] args)
        {
            Console.SetWindowSize(69, 25);
            Console.CursorVisible = false;
            Console.SetCursorPosition(20, 12);
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("ENTER ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("To Start the Game!");
            ConsoleKeyInfo last = Console.ReadKey();
            Thread thread = new Thread(Move);
            thread.Start();
            Console.Clear();      

                while (ok)
                {
                    
                ConsoleKeyInfo pressed = Console.ReadKey();
                if(pressed.Key == ConsoleKey.UpArrow)
                {       
                    if(d != 2 || Snake.body.Count <= 1)      
                           d = 1;
                }
                if (pressed.Key == ConsoleKey.DownArrow)
                {       
                    if(d != 1 || Snake.body.Count <=1)
                        d = 2;
                }
                if (pressed.Key == ConsoleKey.RightArrow)
                {       
                    if(d != 4 || Snake.body.Count <= 1)
                        d = 3;
                }
                if (pressed.Key == ConsoleKey.LeftArrow)
                {
                    if(d != 3 || Snake.body.Count <= 1)
                        d = 4;
                }
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
                if (pressed.Key == ConsoleKey.Escape)
                {
                    break;
                }                

               // Console.Clear();
                
            }
            
        }
    }
}
