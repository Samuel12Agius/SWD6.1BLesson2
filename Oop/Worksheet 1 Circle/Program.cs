using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet_1_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) ->> object is when you create a space in the memory and you start assinging values to the template you createrd earlier
            Circle c = new Circle(); //e.g. of an object --> c


            Console.WriteLine("Input a radius:");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {c.GetArea(), 2}");
            Console.WriteLine($"Perimeter is {c.GetPerimeter(), 2}");

            Console.WriteLine("Press a key to terminate");
            Console.ReadKey();
        }
    }
}
