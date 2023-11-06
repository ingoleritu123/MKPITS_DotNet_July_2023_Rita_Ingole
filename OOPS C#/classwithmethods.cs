using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classexwithmwthodsC_
{
    internal class Program
    {
        class Customer
        {
            int Customer_code;
            string Customer_name;

            public void getdata(int cc, string cn)
            {
                Customer_code = cc;
                Customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer_Name:" + Customer_name);
                Console.WriteLine("Customer_Code:" + Customer_code);
            }
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();

            cust.getdata(123,"rita");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
