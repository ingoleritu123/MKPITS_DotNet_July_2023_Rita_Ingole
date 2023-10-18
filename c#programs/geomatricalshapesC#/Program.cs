using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geomatricalshapesC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu_no, radius, l, b, b1, h;
            float area;

            Console.WriteLine("Enter Number By Your Choice:"+"1-Circle,2-Rectangle,3-Square,4-Triangle,5-Parallelogram:");
            menu_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                           ");  

            if (menu_no == 1)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("GEOMATRICAK SHAPE CIRCLE:  ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("                           ");            
                Console.WriteLine("Enter radius:");
                radius = Convert.ToInt32(Console.ReadLine());
                area = 3.14f * radius * radius;
                Console.WriteLine("area of circle =" + area);
                Console.WriteLine("                           " );  
            }
            else if (menu_no == 2)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("GEOMATRICAK SHAPE RECTANGLE:");
                Console.WriteLine("----------------------------");
                Console.WriteLine("                            ");
                Console.WriteLine("Enter Length:");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter breadth:");
                b = Convert.ToInt32(Console.ReadLine());

                area =l*b ;
                Console.WriteLine("area of Rectangle =" + area );
                Console.WriteLine("                           ");  
            }
            else if(menu_no==3)
            {
                Console.WriteLine("-------------------------" );
                Console.WriteLine("GEOMATRICAK SHAPE SQUARE:" );
                Console.WriteLine("-------------------------" );
                Console.WriteLine("                          ");
                Console.WriteLine("Enter Length:");
                l = Convert.ToInt32(Console.ReadLine());

                area = l * l;
                Console.WriteLine("area of Square =" + area);
                Console.WriteLine("                          ");

            }
            else if (menu_no == 4)
            {
                Console.WriteLine("------------------------- ");
                Console.WriteLine("GEOMATRICAK SHAPE TRIANGLE:");
                Console.WriteLine("------------------------- ");
                Console.WriteLine("                          ");

                Console.WriteLine("Enter base:");
                b1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter hheight:");
                h = Convert.ToInt32(Console.ReadLine());

                area = 1/2*(b1*h);
                Console.WriteLine("area of Rectangle =" + area);
                Console.WriteLine("                           ");
            }
            else if (menu_no == 5)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("GEOMATRICAK SHAPE PARALLELOGRAM:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("                           ");
                Console.WriteLine("Enter base:");
                b1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height:");
                h = Convert.ToInt32(Console.ReadLine());

                area = b1 * h;
                Console.WriteLine("area of Parallelogram =" + area);
                Console.WriteLine("                           ");
            }
            else
            {
                Console.WriteLine("Opps!!!Please Select a No As You Are Given.");
            }
            Console.ReadLine();


             










        }
       


    }
}
