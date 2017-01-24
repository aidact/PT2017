using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Program
    {
        class Student //создаем новый класс
        {
            public string name; 
            public string surname;
            public double gpa;
            public Student (string name, string surname)
                 {
                     this.name = name; // указываем на экзэмпляр
                     this.surname = surname;
                 }
            public double GPA()
            {
                return gpa;
            }
        }
        
        static void Main(string[] args)
        {
            Student a = new Student("Lola", "Umarova"); // задаем все значения
            a.gpa = 3.98;
            Console.WriteLine(a.name +' '+ a.surname +' '+ a.gpa); // вывод на экран
            Console.ReadKey();
        }
    }
}
