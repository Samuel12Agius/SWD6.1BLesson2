using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_IntroToOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.IdCard = "3838383m"; //write

            //Console.WriteLine(p.IdCard); //read

            p.Name = "Ryan";
            p.Surname = "Attard";
            /*
            Console.WriteLine("Please press a key to continue");
            Console.ReadLine(); // This expects user clicks on the Enter key on the keyboard

            Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, Id: {p.IdCard}");

            Console.ReadKey();// This expects the user clicks on any key.
            */

            Console.WriteLine("Please input Address:");
            p.Address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press a key to terminate app...");
            Console.ReadKey();
      


        }
    }
}
