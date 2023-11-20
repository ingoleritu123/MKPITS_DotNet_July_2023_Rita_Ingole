using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtimepoly_BaseclassShape
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawwing");
        }
    }
    public class Rectangle : shape 
    {
        public override void draw()
        {
            Console.WriteLine("draw by pensil");
        }
    }
    public class Circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("draw circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s = new shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine(); 


        }
    }
}
