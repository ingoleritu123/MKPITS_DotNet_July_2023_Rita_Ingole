using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancesinglelavelEx
{
    class Person
    {
        public string name;
    }
    class student:Person
    {
        public int id;
        public int roll_no;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.name = "ritu";
            stud.id = 2345;
            stud.roll_no = 34;

            Console.WriteLine("Name:" + stud.name);
            Console.WriteLine("Id:" + stud.id);
            Console.WriteLine("Roll_No:" + stud.roll_no);
            Console.ReadKey();
        }
    }
}
