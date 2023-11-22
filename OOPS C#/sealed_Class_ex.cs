using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Ex
{

    sealed class student
    {

    }
    class parttimestudent : student // error since student is declared sealed 
    { }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

}
