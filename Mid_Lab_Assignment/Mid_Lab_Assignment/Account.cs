using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment
{
    class Account
    {
        protected string accountName, dob, adress;
        protected string accountNumber;
        protected double balance;
        protected int transaction = 0, type;

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string Dob
        {
            set { this.dob = value; }
            get { return this.dob; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public int AccountType
        {
            set { this.type = value; }
            get { return this.type; }
        }

        public int AccountTransfer
        {
            get { return this.transaction; }
        }

        public string Adress
        {
            set { this.adress = value; }
            get { return this.adress; }
        }

        public void withdraw(double amount)
        {
            if (amount > 0)
            {
                this.balance = balance - amount;
                this.transaction++;
            }
        }
        public void deposite(double amount)
        {
            if (amount > 0)
            {
                this.balance = balance + amount;
                this.transaction++;
            }
        }

        public void Transfer(Account reciever, double amount)
        {
            this.withdraw(amount);
            reciever.deposite(amount);
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine("\nAcount Name:{0}\nAccount Balance:{1}\nAdress:{2}\n", this.accountName, this.balance, this.adress);
        }

    }
}

