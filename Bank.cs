using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // First method to implemet Encapsulation
    public class Bank1
    {
        private double balance;

        //Accessor
        public double getBalance()
        {
            return balance;
        }

        //Mutator
        public void setBalance(double balance)
        {
            if(balance <= 0)
            {
                Console.WriteLine("Balance is less than Zero");
            }
            else
            {
                this.balance = balance;
            }
        }
    }

    // Another method to implemet Encapsulation
    public class Bank2
    {
        private double balance;
        public double Balance
        {
            get
            {

                return balance;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Balance is less than Zero");
                }
                else
                {
                    this.balance = value;
                }
            }
        }
    }
}