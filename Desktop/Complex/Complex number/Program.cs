using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        class Complex //create a class 
        {
            //added data
            public int x;
            public int y;
            public Complex(int x, int y) //make a constructor
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
                Complex c = new Complex((x.x * y.y + y.x * x.y)/ gcd(x.x * y.y + y.x * x.y, x.y * y.y), (x.y * y.y) / (gcd(x.x * y.y + y.x * x.y, x.y * y.y)));



                return (c);
                
           
            }
        
            //provide overload a binary operator -
            public static Complex operator -(Complex x, Complex y)
            {
                //changed the purpose of  -  by adding new class 
                Complex c = new Complex((x.x * y.y - y.x * x.y)/ gcd(x.x * y.y + y.x * x.y, x.y * y.y), x.y * y.y/ gcd(x.x * y.y + y.x * x.y, x.y * y.y));
                return c;
            }
            //provide overload a binary operator /
            public static Complex operator /(Complex x, Complex y)
            {
                //changed the purpose of  /  by adding new class 
                Complex c = new Complex(x.x * y.y/gcd(x.x * y.y, x.y * y.x), x.y * y.x/ gcd(x.x * y.y, x.y * y.x));
                return c;
            }
            //provide overload a binary operator *
            public static Complex operator *(Complex x, Complex y)
            {
                //changed the purpose of  *  by adding new class 
                Complex c = new Complex(x.x * y.x/ gcd(x.x * y.x, x.y * y.y), x.y * y.y / gcd(x.x * y.x, x.y * y.y));

                return c;
            }
            static void Main(string[] args) // function to split complex numbers
            {
                string s = Console.ReadLine();
                string[] arr = s.Split(); // breaks a complex numbers into parts until space: 1/2 3/4
                Complex sum = new Complex(0, 0); // created class and declared atributes as zeros
                foreach (string ss in arr) // instead of for we use foreach to work with string array
                {
                    string[] t = ss.Split('/'); // breaks a complex numbers into parts until "/": 1 2 3  4
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (sum.x == 0 & sum.y == 0) // because we have declared class as zeros, first condition is always true
                    {
                        sum = p;
                    }
                    else
                    {
                        sum = sum + p; // adds one complex number to another 
                    }
                }

                Complex sub = new Complex(0, 0); // created class and declared atributes as zeros
                foreach (string ss in arr)
                {
                    string[] t = ss.Split('/');// breaks a complex numbers into parts until "/": 1 2 3  4
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (sub.x == 0 & sub.y == 0) // because we have declared class as zeros, first condition is always true
                    {
                        sub = p; // we declare first element as an first complex number that we write through console
                                 
                    }
                    else
                    {
                        sub = sub - p;
                    }
                }
                Complex mul = new Complex(0, 0); // created class and declared atributes as zeros
                foreach (string ss in arr) // 
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (mul.x == 0 & mul.y == 0) // because we have declared class as zeros, first condition is always true
                    {
                        mul = p;
                         // we declare first element as an first complex number that we write through console
                         // if we wrote like that  mul.x = p.x;  mul.x = p.y;, it would be easier to understand what happens

                    }
                    else
                    {
                        mul = mul * p; // multiply current complex number with previous
                    }
                }

                Complex div = new Complex(0, 0);
                foreach (string ss in arr) // instead of for we use foreach to work with string array
                {
                    string[] t = ss.Split('/');
                    Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                    if (div.x == 0 & div.y == 0)
                    {
                        div = p; // we declare first element as an first complex number that we write through console
                    }
                    else
                    {
                        div = div / p; // divides current complex number by previous
                    }

                }
                // coz we have changed Tostring(), now it shows atributs of complex number as an complex number
                Console.WriteLine(sum); 
                Console.WriteLine(sub); 
                Console.WriteLine(div); 
                Console.WriteLine(mul); 


                Console.ReadKey();


            }
        }
    }
}