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
            Console.WriteLine("Enter a num: ");
            //int num = Convert.ToInt16(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            if (num%2 == 0) {
                Console.WriteLine("Number is Even");
                num += 100;
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}