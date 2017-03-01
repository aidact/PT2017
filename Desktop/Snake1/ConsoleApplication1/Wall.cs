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
    class Wall
    {
        public char sign = '■';
        public static List<Point> body = new List<Point>();
        public ConsoleColor color = ConsoleColor.Red;
        
        public Wall()
        {
            int row = 0;
            FileStream fs = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                for (int j = 0; j < line.Length; j++)
                    if (line[j] == '*')
                        body.Add(new Point(j, i));
            }
            row++;
            sr.Close();
        }
        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.ForegroundColor = color;
                //foreach(Point p in body)
                
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                
            }
        }

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("../serialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                bf.Serialize(fs, Program.wall);
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
            Program.wall = bf.Deserialize(fs) as Wall;
            fs.Close();
        }
    }
}

