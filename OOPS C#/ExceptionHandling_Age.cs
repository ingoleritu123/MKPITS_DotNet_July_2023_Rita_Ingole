using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_ByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            try
            {
                Console.WriteLine("Enter Age:");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("age should be greater than or equals to 18");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Enter age greater than or Equal to 18");
                Console.WriteLine("Enter your age:");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
                Console.WriteLine("age:" + age);
            }
            Console.WriteLine("see you");
        }
    }
}
