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
        
        public void Draw()
        {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(location.x, location.y);
                Console.Write(sign);
           
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("../serialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
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
            FileStream fs = new FileStream("../serialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.food = bf.Deserialize(fs) as Food;
            fs.Close();
        }
    }
}
