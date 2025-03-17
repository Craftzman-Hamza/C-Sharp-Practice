using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Animal
    {
        //To overrride this method we need to use virtual keyword along with function type
        public virtual void eat() 
        {
            Console.WriteLine("Animal eats...");
        }
    }

    public class Cat : Animal 
    {
        public void eat()
        {
            //Refers to base class
            base.eat();
            Console.WriteLine("Cat eats...");
        }
    }
}