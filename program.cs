using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);            
            numberList.Add(6);        
            numberList.Add(7);
            numberList.Add(8);
            numberList.Add(9);
            numberList.Add(10);

            SimpleCalculator calculatorObj = new SimpleCalculator();
            var x = calculatorObj.Add(15, 10);
            var y = calculatorObj.Add(15, 10, 5);
            var z = calculatorObj.Add(numberList);
            var result1 = calculatorObj.Divide(2,10);
            var result2 = calculatorObj.Divide(15.5,3.5);
            Console.WriteLine("Addition of 2 Int " + x);
            Console.WriteLine("Addition of 3 Int " + y);
            Console.WriteLine("Addition of List of Int " + z);
            Console.WriteLine("Integer divided by Interger " + result1);
            Console.WriteLine("Double divided by Double " + result2);

            Console.ReadKey();
        }
    }
}