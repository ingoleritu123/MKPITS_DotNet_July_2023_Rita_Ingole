using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseclass_vehical_byinheritance
{
    class vehical
    {
        public int make;
        public string model;
    }
    class car : vehical
    {
        public int no_door;
        public string fuel_type;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.make = 2001;
            c.model = "Varna";
            c.no_door = 4;
            c.fuel_type = "diesel";
            Console.WriteLine("Year Of Making:" + c.make);
            Console.WriteLine("Model:" + c.model);
            Console.WriteLine("No_ofDoor:" + c.no_door);
            Console.WriteLine("Fuel_Type:" + c.fuel_type);
            Console.ReadKey();


        }
    }
}
