using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a_b
{
    class Program
    {
         public static void Main (string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + (a + b).ToString());
            Console.ReadKey();
        }
    }
}
