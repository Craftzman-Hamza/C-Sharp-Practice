using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Inheriting SimpleCalculator Class
    internal class ScientificCalculator : SimpleCalculator
    {
        public double Sin(double radius)
        {
            return Math.Sin(radius);
        }
    }
}