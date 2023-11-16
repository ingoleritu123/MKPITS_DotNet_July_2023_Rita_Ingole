using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bclasspersonbymethod
{
    class Person
    {
        public string name;
        public int age;
    }
    class Student:Person
    {
        public int roll_no;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.name = "ritu";
            S.age = 20;
            S.roll_no = 31;
            S.marks = 95;

            Console.WriteLine("Name:" + S.name);
            Console.WriteLine("Age:" + S.age);
            Console.WriteLine("Roll_no:" + S.roll_no);
            Console.WriteLine("Marks:" + S.marks);
            Console.ReadKey();

        }
    }
}
