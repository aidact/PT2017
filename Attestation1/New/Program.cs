using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Sol()
        {
            StreamReader sr = new StreamReader(@"c:HW\a.txt");
            StreamWriter sw = new StreamWriter(@"c:HW\b.txt");
            string[] arr = sr.ReadLine().Split();
                      
                sw.WriteLine("max:" + arr.Max() + ' ' + "min:" + arr.Min());
                sr.Close();
                sw.Close();
            
        }
        static void Main(string[] args)
        {
            Sol();
            //Console.ReadKey();
            
        }
    }
}
