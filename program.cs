using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization
            Employee employeeObj = new Employee();

            //Setting Properties
            employeeObj.Id = 1;
            employeeObj.Name = "Hamza";
            employeeObj.Department = "Game QA";

            //Actions
            employeeObj.CheckIn();
            employeeObj.CheckOut();

            Console.ReadKey();
        }
    }
}