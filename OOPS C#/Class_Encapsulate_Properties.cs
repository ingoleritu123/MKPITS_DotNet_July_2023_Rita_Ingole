using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Encapsulate_properties
{


   

        class employee
        {
           
            public string empname { get; set; }
        }
        class Program
        {
            static void Main(string[] args)
            {
            employee emp = new employee();
            emp.empname = "ravi"; 
            Console.WriteLine("empname " + emp.empname);
            Console.ReadKey();
            }
        }

    
}
