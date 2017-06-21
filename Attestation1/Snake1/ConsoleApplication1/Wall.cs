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
        
        public Wall(int x)
        {
           /* level = 0;
            int row = 0;
            String filename = String.Format("1.txt", level);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '*')
                    {
                        body.Add(new Point(i, row));
                    }
                }
                row++;
            }

            sr.Close();*/

            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Aida\Desktop\test");
            FileInfo[] f = d.GetFiles();
            StreamReader sr = new StreamReader(f[x].FullName);
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == '*')
                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
           
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

        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            File.Delete("../wall.xml");
            FileStream fs = new FileStream("../wall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
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
            FileStream fs = new FileStream("../wall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.wall = bf.Deserialize(fs) as Wall;
            fs.Close();
        }

        /*public void Save()
        {
            string fileName = "";

            fileName = @"C:HW\wall.xml";
            File.Delete("wall.xml");
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Wall));

            xs.Serialize(fs, this);
            fs.Close();
        }
        public void Resume()
        {
            string fileName = "";

            fileName = @"C:HW\wall.xml";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Wall));

            Program.wall = xs.Deserialize(fs) as Wall;
            fs.Close();
        }*/
    }
}

