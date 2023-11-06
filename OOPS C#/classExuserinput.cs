using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExuserinputC_
{
    internal class Program
    {
        class Customer
        {
            int Customer_code;
            string Customer_name;

            public void getdata(int Customer_code, string Customer_name)
            {
                this.Customer_code = Customer_code;
                this.Customer_name = Customer_name;
            }
            public void displaydata()
            {
                Console.WriteLine("Coustomer Code:" + Customer_code);
                Console.WriteLine("Coustomer Name:" + Customer_name);
            }
            
              
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();

            int C_c;
            string C_n;


            Console.WriteLine("Enter Employee Code:");
            C_c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            C_n =Console.ReadLine();


            cust.getdata(C_c, C_n);
            cust.displaydata();

            Console.ReadLine();
        }
    }
}
