using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace NotPrime
{
    class Program
    {
        static bool check (int a)
        {
             
             if (a % 2 == 0)
                return true;
             return false;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] d = s.Split();

            int n = d.Length;

            for(int i=0; i<n ; i++){
               string t = d[i];
               int q = int.Parse(t); 
               if (check(q)) 
                   Console.WriteLine(t + ' ');
            }
            Console.ReadKey();
        }
    }
}
