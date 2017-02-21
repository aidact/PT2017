using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Xml.Serialization;


namespace serial1
{
    public class Subject
    {
        public String name;
        public Subject() { }
        public Subject(String name)
        {
            this.name = name;
        }
    }
   public class Student
    {
        public String name;
        public String surname;
        public int age;
        public List<Subject> subjects;
        public Student() { }
        public Student(string name, String surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            subjects = new List<Subject>();
            subjects.Add(new Subject("Programming languages"));
            subjects.Add(new Subject("Programming technologies"));
        }
    }
    class Program
    {
        static void F2()
        {
            StreamReader sr = new StreamReader("student.txt");
            Student a = new Student();
            a.name = sr.ReadLine();
            a.surname = sr.ReadLine();
            a.age = int.Parse(sr.ReadLine());
            sr.Close();
        }
        static void F1()
        {
            Student a = new Student("Almas", "Abuev", 23);
            StreamWriter sw = new StreamWriter("student.txt");
            sw.WriteLine(a.name);
            sw.WriteLine(a.surname);
            sw.WriteLine(a.age);
            sw.Close();
        }
        static void F3()
        {
            Student a = new Student("Almas", "Abuev", 23);
            FileStream fs = new FileStream("../student.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            xs.Serialize(fs, a); //(куда сериализуем, что сериализуем)
            fs.Close();

        }
        static void F4()
        {
            FileStream fs = new FileStream("../student.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student a = (Student)xs.Deserialize(fs);
            Console.WriteLine(a.name + ' ' + a.surname + ' ' + a.age);
            Console.ReadKey();
            fs.Close();
        }
        static void Main(string[] args)
        {
            F3();
        }
    }
}
