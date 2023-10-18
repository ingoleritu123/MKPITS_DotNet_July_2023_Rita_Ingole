using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalfareinC_
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string origin, destination,date;
            int  train_no, total_fare=0;
            string Class,passenger_name;

            Console.WriteLine("------WELCOME TO ECART EXPRESS------");
            Console.WriteLine("                                    ");

            Console.WriteLine("---Please Enter Require Details---");
            Console.WriteLine("                                    ");


            Console.WriteLine("Enter Passenger Name :");
            passenger_name = Console.ReadLine();


            Console.WriteLine("Enter Your Train_no:");
            train_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Name of Class :");
            Class = Console.ReadLine();


            Console.WriteLine("Enter The Name of Origin :");
            origin = Console.ReadLine();

            Console.WriteLine("Enter The Name of Destination :");
            destination = Console.ReadLine();

            Console.WriteLine("Enter Date:");
            date =Console.ReadLine();

            if (destination == "mumbai")
                total_fare = 1500;
            else if (destination == "pune")
                total_fare = 10000;
            else if (destination == "nashik")
                total_fare = 15000;
            else if (destination == "delhi")
                total_fare = 20000;

            Console.WriteLine("                                    ");

            Console.WriteLine("---| Entered Details by Pasanger |---");
            Console.WriteLine("                                    ");

            Console.WriteLine("Pasanger_Name: {0}\n Origin:{1} \n Destination:{2} \nTrain_no:{3} \nClass:{4} \nDate:{5}", passenger_name, origin, destination, train_no, Class, date);
            Console.WriteLine("Total_fare :" + total_fare);
            Console.ReadLine();


















        }
    }
}
