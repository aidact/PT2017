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
            int max=0, min=100000;
            StreamReader sr = new StreamReader(@"c:\Users\Aida\Desktop\track\a.txt");
            StreamWriter sw = new StreamWriter(@"c:\Users\Aida\Desktop\track\b.txt");
            string[] arr = sr.ReadLine().Split();

            foreach (string q in arr)
            {
                int n = Math.Abs(q);

                if (max <= int.Parse(q)) 
                {
                    max = int.Parse(q);
                }

                if (min >= int.Parse(q)) 
                {
                    min = int.Parse(q);
                }
            }
            sw.WriteLine("Max:" + max + ' ' + "Min" + min);
            sr.Close();
            sw.Close();
            

        }
        static void Main(string[] args)
        {
            Sol();

        }
    }
}
