using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MID1
{
    class Program
    {
        public static void check(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.Write(i + " "); 
                }
            }
        }
        static void Main(string[] args)
        {


            string str = Console.ReadLine();
            int q = Convert.ToInt32(str);         
            check(q);

            Console.ReadKey();
        }
    }
}
