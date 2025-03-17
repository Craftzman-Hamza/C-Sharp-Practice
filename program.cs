using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accountBalance1 = 0;
            double accountBalance2 = 1000;

            Bank1 bankObj = new Bank1();
            bankObj.setBalance(accountBalance1);
            Console.WriteLine(bankObj.getBalance());

            Bank2 bankObj2 = new Bank2();
            bankObj2.Balance = accountBalance2;
            Console.WriteLine(bankObj2.Balance);

            Console.ReadKey();
        }
    }
}