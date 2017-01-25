using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex
{
    class Complex
    {
        public int x, y;
        public int a, nod = 1, d = 1;
        public int z, q;
        public Complex(int x, int y) // создаем конструктор
        {
        this.x = x; // инициализируем атрибуты класса
        this.y = y;
        }
    

           public static Complex operator +(Complex c1, Complex c2) // осуществляем перегрузку бинарного оператора +
        {
            Complex c = new Complex(c1.x*c2.y+c2.x*c1.y, c1.y*c2.y); // меняем работу оператора + с помощью нового класса
            return c;
        }
         /*   public int gcd(int a, int b)
           {
               if (b == 0)
                   return a;

               return gcd(b, a % b);
           }*/
       
        static void Main(string[] args)
           {
               int a, nod = 1, d = 1, z, q;
               
               
               string inp = Console.ReadLine(); // прочитываем строку
               string[] arr = inp.Split(); // отделяем строку от пробелов

               Complex sum = new Complex(0, 1);
               foreach (string s in arr)
               {
                   
                   string[] t = s.Split('/'); 
                   Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                   sum = sum + p;
               }
               z = sum.x; // заводим новую численную переменную, в которой сохраняем атрибут класса
               q = sum.y; // заводим новую численную переменную, в которой сохраняем атрибут класса
               a = z;
               if (q > z) a = q; // алгоритм нахождения НОД
               for (int i = 1; i <= a; i++)
               {
                   if (d > nod) nod = d;
                   if (z % i == 0 && q % i == 0) 
                   {
                       d = i;
                   }
               }
                Console.WriteLine(z/nod+"/"+q/nod); // разделяем атрибуты класса на НОД для того, чтобы дробь сокращалась

               
                
               
                 Console.ReadKey();

           }
    }
}
