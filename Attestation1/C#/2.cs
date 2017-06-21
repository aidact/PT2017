using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t;
            a = Convert.ToInt32(Console.ReadLine());
            for(int i=2; i<10; i++)

                if (a % i != 0)
                {
                    a = t;
                }
                
                    Console.WriteLine(t.ToString());
                Console.ReadKey();
        }
    }
}
