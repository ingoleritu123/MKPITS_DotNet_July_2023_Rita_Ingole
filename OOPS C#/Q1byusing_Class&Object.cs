using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1byusing_Class_Object
{
    class student
    {
        public string name;
        public int id;

        public void getdata(string name,int id)
        {
            this.name = name;
            this.id = id;
        }

        public void displaydata()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getdata("rita", 123);
            s.displaydata();
            Console.ReadLine();
        }
    }
}
