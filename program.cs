using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization
            SimpleCalculator calculatorObj = new SimpleCalculator();
            double result = calculatorObj.Add(10, 2);
            Console.WriteLine("Result is " + result);

            //Initializing Object from Inheritance Class
            ScientificCalculator calculatorObj0 = new ScientificCalculator();
            double result0 = calculatorObj0.Add(10, 2);
            Console.WriteLine("Result0 is " + result0);

            double result1 = calculatorObj0.Sin(30);
            Console.WriteLine("Result1 is " + result1);

            Console.ReadKey();
        }
    }
}