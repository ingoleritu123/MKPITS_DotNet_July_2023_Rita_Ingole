using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfface_shape
{
    interface shape
    {
        void draw();
    }
    class rectangle:shape
    {
        public void draw()
        {
            Console.WriteLine("code to draw rectangle:");
        }
    }
    class Circle : shape
    {
        public void draw()
        {
            Console.WriteLine("code to draw Circle:");
        }
    }
    internal class Program


    {
        static void Main(string[] args)
        {
            shape s;
            s = new rectangle();
            s.draw();

            
            s = new Circle();
            s.draw();

            Console.ReadLine();




        }
    }
}
