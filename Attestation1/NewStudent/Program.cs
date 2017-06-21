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
            public Student(string name, double gpa)
            {
                this.name = name;
                this.gpa = gpa;
            }
           
            public override string ToString() // функция возврощающая данные в виде string
            {
                return name+' '+surname+' '+gpa;
            }
            
        }
        
        static void Main(string[] args)
        {
            Student a = new Student("Lola", "Umarova"); // задаем все значения
            a.gpa = 3.98;
            Console.WriteLine(a); // вывод на экран
            Console.ReadKey(); // окно не будет закрыто пока мы не нажмем какую-либо клавишу
        }
    }
}
