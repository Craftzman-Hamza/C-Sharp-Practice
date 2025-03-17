using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        readonly double radius = 0;
        //Constructor
        public Program(double r)
        {
            radius = r;
        }

        static void Main(string[] args)
        {
            //Calculate area of Circle
            // pi * r^2
            const double pi = 3.142;

            var programObj = new Program(5);
            double area = pi * Math.Pow(programObj.radius, 2);
            Console.WriteLine("Area of circle is: " + area);

            Console.ReadLine();
        }
    }
}