using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedAccessModifier
{
    class student
    {
        protected string name;
        public void getdata()
        {
            name = "rita";
            Console.WriteLine("name:" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getdata();
            Console.ReadLine();
        }
    }
}
