using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails_ArrayList
{
    class Product
    {
        public int product_id;
        public string produt_name;
        public int product_rate;
        public Product(int product_id,string product_name,product_rate)
        {
            this.product_id = product_id;
            this.produt_name = product_name;
            this.product_rate = product_rate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(123, "milk_bar", 500);
            Product p1 = new Product(567, "milk", 200);
            Product p2 = new Product(897, "soap", 700);

            ArrayList arr = new ArrayList();
            arr.Add(p);
            arr.Add(p1);
            arr.Add(p2);

            foreach(Product p in arr)
            {
                Console.WriteLine("Product_Id:" + product_id);
                Console.WriteLine("Product_Name:" + product_name);
                Console.WriteLine("Product_rate:" + product_rate);
            }
            Console.ReadLine();
        }
    }
}
