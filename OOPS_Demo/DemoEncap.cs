using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    internal class DemoEncap
    {
        private int balance;

        public DemoEncap(int initialbalance) {
            balance = initialbalance;
        }

        public void deposit(int amount)
        {
            balance += amount;
        }

        public void withdraw(int amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("insufficient funds.");
            }
        }

        public int getbalance()
        {
            return balance;
        }
    }
}
