using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    [Serializable]
      class Snake
    {
        public char sign;
        public ConsoleColor color;
        public static List<Point> body;
        public int cnt = 0;

        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();
            body.Add(new Point(25, 12));
        }

        public void Move(int dx, int dy)
        {
            for (int j = Snake.body.Count() - 1; j >= 0; j--)
            {
                Console.SetCursorPosition(Snake.body[j].x, Snake.body[j].y);
                Console.Write(' ');
            }
           
            for (int i = body.Count - 1; i >= 1; i--)
            {
                body[i].x = body[i - 1].x;

                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x > 49)
                body[0].x = 1;
            if (body[0].x < 1)
                body[0].x = 49;

            if (body[0].y > 25)
                body[0].y = 1;
            if (body[0].y < 1)
                body[0].y = 25;

            BangAtWall();
            BangAtBody();

            if (CanEat(Food.location))
            {
                Food.SetRandomPosition();
            }
        }
        public bool CanEat(Point location)
        {
            if (body[0].x == location.x && body[0].y == location.y)
            {
                body.Add(new Point(location.x, location.y));
                cnt++;
                return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public static void BangAtWall()
        {
            foreach (Point p in Wall.body)
            {
                if (Snake.body[0].x == p.x && Snake.body[0].y == p.y)
                {
                    Program.ok = false;
                    Console.Clear();
                    Console.SetCursorPosition(28, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GAME OVER");
                    Console.ReadKey();
                }
            }
        }
        public static void BangAtBody()
        {
            for(int i = 1; i < Snake.body.Count; i++)
            {
                if (Snake.body[0].x == Snake.body[i].x && Snake.body[0].y == Snake.body[i].y)
                {
                    Program.ok = false;
                    Console.Clear();
                    Console.SetCursorPosition(28, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GAME OVER");
                    Console.SetCursorPosition(28, 13);                    
                    Console.ReadKey();
                }
            }
        }
        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            File.Delete("../snake.xml");
            FileStream fs = new FileStream("../snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                bf.Serialize(fs, Program.snake);
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            fs.Close();
        }
        public void Resume()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("../snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.snake = bf.Deserialize(fs) as Snake;
            fs.Close();
        }


        /*public void Save()
        {
            //File.Delete("snake.xml");
            FileStream fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            try
            {
                xs.Serialize(fs, this);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            fs.Close();
        }

        public void Resume()
        {
            string fileName = "";

            fileName = @"C:HW\snake.xml";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Snake));

            Program.snake = xs.Deserialize(fs) as Snake;
            fs.Close();
        }*/
    }
}
