using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment
{
    class SavingsAccount : Account
    {
        public double minamount;



        public SavingsAccount(double a)
        {
            this.minamount = a;

        }



        public void Withdraw(double amount)
        {
            if (base.Balance > amount && amount > 0)
            {
                base.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Else Sorry not Sufficient Balance");
            }
        }

        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                base.Balance += amount;
            }
            else { Console.WriteLine("DENY"); }
        }

    }
}

