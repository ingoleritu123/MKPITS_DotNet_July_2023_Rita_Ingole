using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace except3subM_PbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;

            Console.WriteLine("Enter marks of 1st subject");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of 2nd subject");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of 3rd subject");
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            Console.WriteLine("total =" + total);
            per = (total / 300.0f) * 100;
            Console.WriteLine("Parcentage =" + per);
            if (per >=75)
                grade = "destinction";
            if (per >= 60 && per < 75)
                grade = "first class";
            else
                grade = "fail";
            Console.WriteLine("grade=" + grade);
            Console.ReadLine();



        }
    }
}
