using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MID2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Aida\Desktop\test3\1.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Aida\Desktop\test3\2.txt");

            string[] arr = sr.ReadToEnd().Split();
            int[] arr1 = new int[arr.Length];
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {   
                arr1[i] = Convert.ToInt32(arr[i]);;
            }
            int mini = Math.Min(arr1[0], arr1[1]);

            for (int i = 1; i <mini + 1; i++)
            {
                if (arr1[0] % i == 0 & arr1[1] % i == 0)
                {
                    sw.Write(i + ' ');
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
