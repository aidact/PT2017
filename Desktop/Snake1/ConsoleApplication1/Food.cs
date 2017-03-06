using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    [Serializable]
    class Food
    {
        public static Point location;
        public static char sign ='#';
        public static ConsoleColor color = ConsoleColor.Green;
        public int cnt = 0;
      

        public Food()
        {
            SetRandomPosition();           
        }
        public static void SetRandomPosition()
        {
            int x = new Random().Next(1, 49);
            int y = new Random().Next(1, 24);
            location = new Point(x, y);
        }

        public static bool FoodnWall(Wall w)
        {
            foreach (Point p in Wall.body)
            {
                if (location.x == p.x & location.y == p.y)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool FoodnBody(Snake s)
        {
            foreach (Point p in Snake.body)
            {
                if (location.x == p.x & location.y == p.y)
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {

                Console.ForegroundColor = color;
                Console.SetCursorPosition(location.x, location.y);
                Console.Write(sign);
           
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            File.Delete("../food.xml");
            FileStream fs = new FileStream("../food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                bf.Serialize(fs, Program.food);
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.Write(e.Message);
                Console.ReadKey();
            }
            fs.Close();
        }
        public void Resume()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("../food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.food = bf.Deserialize(fs) as Food;
            fs.Close();
        }

        /*public void Save()
        {
            string fileName = "";

            fileName = @"C:HW\food.xml";
            File.Delete("food.xml");
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            xs.Serialize(fs, this);
            fs.Close();
        }
        public void Resume()
        {
            string fileName = "";

            fileName = @"C:HW\food.xml";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            Program.food = xs.Deserialize(fs) as Food;
            fs.Close();
        }*/
    }
}
