using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        class Complex //creat a class
        {
            //added datas
            public int x;
            public int y;
            public Complex(int x, int y) //creat a constructor
            {
                //initialize class attributes
                this.x = x;
                this.y = y;
            }
            //rewrite function ToString()
            public override string ToString()
            {
                return x + "/" + y;
            }
            //function to find gcd of two complex numbers
            static int gcd(int x, int y)
            {
                if (x == 0)
                    return y;
                return gcd(y % x, x);
            }
            //provide overload a binary operator +
            public static Complex operator +(Complex x, Complex y)
            {
                //changed the purpose of  +  by adding new class 
                Complex c = new Complex(x.x * y.y + y.x * x.y, x.y * y.y);
                return c;
            }
            //provide overload a binary operator -
            public static Complex operator -(Complex x, Complex y)
            {
                //changed the purpose of  -  by adding new class 
                Complex c = new Complex(x.x * y.y - y.x * x.y, x.y * y.y);
                return c;
            }
            //provide overload a binary operator /
            public static Complex operator /(Complex x, Complex y)
            {
                //changed the purpose of  /  by adding new class 
                Complex c = new Complex(x.x * y.y, x.y * y.x);
                return c;
            }
            //provide overload a binary operator *
            public static Complex operator *(Complex x, Complex y)
            {
                //changed the purpose of  *  by adding new class 
                Complex c = new Complex(x.x * y.x, x.y * y.y);

                return c;
            }
            static void Main(string[] args)
            {
                string s = Console.ReadLine();
                string[] arr = s.Split();
                Complex sum = new Complex(0, 0);
                foreach (string ss in arr)
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (sum.x == 0 & sum.y == 0)
                    {
                        sum = p;
                    }
                    else
                    {
                        sum = sum + p;
                    }
                }

                Complex sub = new Complex(0, 0);
                foreach (string ss in arr)
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (sub.x == 0 & sub.y == 0)
                    {
                        sub = p;
                    }
                    else
                    {
                        sub = sub - p;
                    }
                }
                Complex mul = new Complex(0, 0);
                foreach (string ss in arr)
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (mul.x == 0 & mul.y == 0)
                    {
                        mul = p;
                    }
                    else
                    {
                        mul = mul * p;
                    }
                }

                Complex div = new Complex(0, 0);
                foreach (string ss in arr)
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (div.x == 0 & div.y == 0)
                    {
                        div = p;
                    }
                    else
                    {
                        div = div / p;
                    }

                }
                //devide to gcd() to get an abbreviated complex number

                Console.WriteLine(sum.x / gcd(sum.x, sum.y) + "/" + sum.y / gcd(sum.x, sum.y));
                Console.WriteLine(sub.x / gcd(sub.x, sub.y) + "/" + sub.y / gcd(sub.x, sub.y));
                Console.WriteLine(mul.x / gcd(mul.x, mul.y) + "/" + mul.y / gcd(mul.x, mul.y));
                Console.WriteLine(div.x / gcd(div.x, div.y) + "/" + div.y / gcd(div.x, div.y));

                Console.ReadKey();


            }
        }
    }
}