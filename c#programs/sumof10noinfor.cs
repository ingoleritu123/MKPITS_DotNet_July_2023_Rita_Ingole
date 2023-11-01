using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace sunof10noinfoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int sum=0;
            double avg=0
                ;
            for (int cnt = 1; cnt <=5; cnt++) 
            {
                Console.WriteLine("Enter no:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                avg = sum / 10.0;

            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avarage = " + avg);
            Console.ReadLine();


        }
    }
}
