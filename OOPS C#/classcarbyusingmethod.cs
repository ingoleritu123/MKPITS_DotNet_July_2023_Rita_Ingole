using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcarbyusingmeythod
{
    class car
    {
        public void start()
        {
            Console.WriteLine("car starting:");
        }
    }
    class wagnor:car
    {
        public void startmusic()
        {
            Console.WriteLine("start music");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            wagnor r = new wagnor();
            r.start();
            r.startmusic();

            Console.ReadLine();

        }
    }
}
