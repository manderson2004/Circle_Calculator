using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Calculator
{
    /*
*Learning Activity 1: Circle Calculator
Write a program that gets the radius of a circle as input from the user, then calculates the circumference and area of the circle and prints the values to the console.
*
*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the radius of your circle in cm:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());

            double circumferenceOfCircle = 2 * Math.PI * circleRadius;
            Console.WriteLine("Circumference = " + circumferenceOfCircle + " cm");

            double areaOfCircle = Math.PI * circleRadius * circleRadius;
            Console.WriteLine("Area = " + areaOfCircle + " cm2");

            Console.Read();

        }
    }
}
