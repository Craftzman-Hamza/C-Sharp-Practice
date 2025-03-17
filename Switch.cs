using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter first num: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second num: ");
            num2 = double.Parse(Console.ReadLine());

            optionsAgain:
            Console.WriteLine("Press 1 to Add");
            Console.WriteLine("Press 2 to Subtract");
            Console.WriteLine("Press 3 to Multiply");
            Console.WriteLine("Press 4 to Divide");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Addition is " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division is " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            goto optionsAgain;
        }
    }
}