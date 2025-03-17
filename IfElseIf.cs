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
            int a = 10;
            int b = 2;

            Console.WriteLine("Pess 1 to Add");
            Console.WriteLine("Pess 2 to Subtract");
            Console.WriteLine("Pess 3 to Multiply");
            Console.WriteLine("Pess 4 to Divide");
            int option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Console.WriteLine("Addition is " + (a + b));
            }
            else if(option == 2)
            {
                Console.WriteLine("Subtraction is " + (a - b));
            }
            else if(option == 3)
            {
                Console.WriteLine("Multiplication is " + (a * b));
            }
            else if(option == 4)
            {
                Console.WriteLine("Division is " + (a / b));
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }

            Console.ReadLine();
        }
    }
}