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
       /* public static void Sol()
        {
            StreamReader sr = new StreamReader(@"c:HW\a.txt");
            StreamWriter sw = new StreamWriter(@"c:HW\b.txt");
            string[] arr = sr.ReadLine().Split();
            foreach (string s in arr)
            {
                string[] p = s.Split();
                sw.WriteLine("max:" + p.Max() + ' ' + "min" + p.Min());
            }
            
        }*/
        static void Main(string[] args)
        {
            //Sol();
            string s = Console.ReadLine();
            string[] p = s.Split();
            //for (int i = 0; i < s.Length; i++)
            
                Console.WriteLine(p.Max() + ' ' + p.Min());
            Console.ReadKey();
        }
    }
}
