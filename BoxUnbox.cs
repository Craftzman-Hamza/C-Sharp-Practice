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
            object obj = 10; //This is boxing value type is converted to reference type
            int num = (int)obj; //This is called unboxing converting refernce value to type value

            Console.WriteLine(obj);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}