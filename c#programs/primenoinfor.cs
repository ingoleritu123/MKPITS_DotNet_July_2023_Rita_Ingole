using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenoinfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=2;
            int flag=1;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(counter=2;counter<num;counter++)
            {
                if (num % counter == 0)
                {
                    flag = 0;
                    break;

                }
            }
            if(flag==0)
            {
                Console.WriteLine("it is not prime no.");
            }
            else
            {
                Console.WriteLine("it is prime no.");           
            
            
            
            }

            Console.ReadLine();
                
                
                
                

        }
    }
}
