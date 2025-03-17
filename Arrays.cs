using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] intArr; //Array Declaration
            //int[] intArr = new int[10]; //Array Initialization

            int[] intArr = new int[10];

            int defaultNum = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = defaultNum;
                defaultNum+=2;
            }

            foreach (var x in intArr)
            {
                Console.WriteLine("Array item " + x);
            }

            Console.ReadLine();
        }
    }
}