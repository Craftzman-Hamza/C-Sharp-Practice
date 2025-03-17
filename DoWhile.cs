using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i  = 0;
            do
            {
                Console.WriteLine("Hello World " + i);
                i++;
            } while (i < 0); //It will execute the block atleast even though condition is getting failed
            

            Console.ReadLine();
        }
    }
}