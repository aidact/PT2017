using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Complex
{
    [Serializable]
    public class Program
    {
        public class Complex
        {
           
            public int x;
            public int y;
            public Complex(int x, int y)
            {               
                this.x = x;
                this.y = y;
           }
            public Complex() { }
            public override string ToString()
            {
                return x + "/" + y;
            }
            
            static int gcd(int x, int y)
            {
                if (x == 0)
                    return y;
                return gcd(y % x, x);
            }
          
            public static Complex operator +(Complex x, Complex y)
            {                
                Complex c = new Complex((x.x * y.y + y.x * x.y) / gcd(x.x * y.y + y.x * x.y, x.y * y.y), (x.y * y.y) / (gcd(x.x * y.y + y.x * x.y, x.y * y.y)));
                return (c);
            }
            
            public static Complex operator -(Complex x, Complex y)
            {               
                Complex c = new Complex((x.x * y.y - y.x * x.y) / gcd(x.x * y.y + y.x * x.y, x.y * y.y), x.y * y.y / gcd(x.x * y.y + y.x * x.y, x.y * y.y));
                return c;
            }
           
            public static Complex operator /(Complex x, Complex y)
            {               
                Complex c = new Complex(x.x * y.y / gcd(x.x * y.y, x.y * y.x), x.y * y.x / gcd(x.x * y.y, x.y * y.x));
                return c;
            }
         
            public static Complex operator *(Complex x, Complex y)
            {            
                Complex c = new Complex(x.x * y.x / gcd(x.x * y.x, x.y * y.y), x.y * y.y / gcd(x.x * y.x, x.y * y.y));
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
                    FileStream fs = new FileStream("../sum.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    XmlSerializer xs = new XmlSerializer(typeof(Complex));
                    xs.Serialize(fs, sum);
                    try
                    {
                        //sum = (Complex)xs.Deserialize(fs);
                        sum = xs.Deserialize(fs) as Complex;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                    }
                    fs.Close();

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
                FileStream f = new FileStream("../sub.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer x = new XmlSerializer(typeof(Complex));
                x.Serialize(f, sub);
               // sub = x.Deserialize(f) as Complex;
                f.Close();

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
                FileStream fi = new FileStream("../mul.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xm = new XmlSerializer(typeof(Complex));
                xm.Serialize(fi, mul);
                
                fi.Close();

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
                FileStream fl = new FileStream("../div.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xl = new XmlSerializer(typeof(Complex));
                xl.Serialize(fl, div);
                //div = xl.Deserialize(fl) as Complex;
                fl.Close();

                Console.WriteLine(sum);
                Console.WriteLine(sub);
                Console.WriteLine(div);
                Console.WriteLine(mul);
                Console.ReadKey();
            }
        }
    }
}