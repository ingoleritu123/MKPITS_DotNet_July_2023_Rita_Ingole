using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveSubMarkUfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks=0;
            int total=0;
            float per;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter your Marks:");
                marks = Convert.ToInt32(Console.ReadLine());
                total = total + marks;

            }
            per = ((float)marks / total) * 100;
            Console.WriteLine("total marks={0} percentage= {1}", total,per);
            Console.ReadLine();
        }
    }
}
