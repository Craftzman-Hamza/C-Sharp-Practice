using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class SimpleCalculator
    {
        public double Add(int x, int y)
        {
            return x + y;
        }
        public double Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Add(List<int> listOfIntegers)
        {
            double sum = 0;
            foreach(var item in listOfIntegers)
            {
                sum += item;
            }
            return sum;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(int x, int y)
        {
            return x / y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}