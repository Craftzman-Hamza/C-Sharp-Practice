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
            //Variale Declaration
            int a;
            float b;
            double c;
            char d;
            byte e;

            //Varibale Initialization
            a = 10;
            b = 3.14f;
            c = 696969;
            d = 'X';
            e = 1;

            //Variable Declartion + Intialization
            int num = 10;

            //Sample Code
            int number1, number2, result;
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine("Result: " + result);
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result);

            Console.ReadLine();
        }
    }
}