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
            object obj = 10; //Check datatype on Compile time
            dynamic dynamicVar = 20; // Check datatype on Run time

            Console.WriteLine(obj);
            Console.WriteLine(dynamicVar);

            Console.ReadLine();
        }
    }
}