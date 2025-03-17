using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void CheckIn()
        {
            Console.WriteLine(Name + " has checked in at " + DateTime.Now);
        }

        public void CheckOut() 
        {
            Console.WriteLine(Name + " has checked out at " + DateTime.Now);
        }
    }
}