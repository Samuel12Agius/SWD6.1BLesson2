using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet_1_Circle
{
    //access modifier - are the level of access to the class and its members
    //e.g. public/private/protected
     public class Circle
    {

        //constructor - bears the same name as the class, which is used to create an instance of a class (The object)
        //Secondary objective of a construct : it can be used as a normal method
        public Circle()//constructor is like the key to start the class / the key to initiliaze the object
        {
            Radius = 0; //setting to default values
            Colour = "Black";
        }

        public string Colour { get; set; }
        public double Radius { get; set; }//property

        /// <summary>
        /// displays the radius value of the instance when called
        /// </summary>
        /// <returns></returns>
        /// 
        public string GetRadius()
        {
            return "Radius:" + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
