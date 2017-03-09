using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace MID3
{
    class Program
    {
        static void Main(string[] args)
        {
            String result = "";

            for (int i = 1; i < 7; i++)
            {
                FileStream fs = new FileStream(String.Format(@"C:\Users\Aida\Desktop\test2\1.txt", i), FileMode.Open, FileAccess.Read);
                FileInfo fi = new FileInfo(String.Format(@"C:\Users\Aida\Desktop\test2\1.txt", i));
                StreamReader sr = new StreamReader(fs);

                String s = sr.ReadLine();

                if (s == "test")
                {
                    result += fi.Name + '\n';
                    Console.WriteLine(result);
                    Console.ReadKey();
                }
                fs.Close();
            }
        }
    }
}
