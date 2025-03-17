using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Hamza";
            myName = "Malik";

            // Following line gives error as we are trying to change a constant variable value
            // const string myName = "Eren";
            // myName = "Yeager";

            //Calculate area of Circle
            // pi * r^2
            const double pi = 3.142;
            Console.WriteLine("Enter Radius of Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = pi * radius * radius;
            Console.WriteLine("Area of Circle is: " + area);

            Console.ReadLine();
        }
    }
}