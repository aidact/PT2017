using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // собственный поток

namespace Potok1
{
    class Program
    {
        static void F1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("in F1:" + i);
                Thread.Sleep(0);// приоритет потока
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(F1);
            thread.Start();

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("in main:" + i);
                Thread.Sleep(0);
            }
            Console.Read();
        }
    }
}
