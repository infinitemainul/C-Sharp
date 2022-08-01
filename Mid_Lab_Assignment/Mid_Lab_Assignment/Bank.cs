using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment
{
    class Bank
    {
        public int count = 0;



        Account[] accounts;
        public Bank(int size)
        {
            this.accounts = new Account[size];
        }

        public void CreateAccount(Account account)
        {

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("***Account Created Successfully !***");
                    Console.WriteLine("Account Number : " + accounts[i].AccountNumber + "\n");
                    count++;
                    break;
                }
            }
        }
        public void PrintAccount(string accountNumber)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    accounts[i].ShowAccountDetails();
                    break;
                }
            }
        }



        public void Performtransaction(string accountnumber, string temp4)
        {
            string amount, name, amount2, amount4;
            int amount1, amount3, amount5;

            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accountnumber)
                {
                    if (temp4 == "deposit") //Deposit
                    {
                        Console.WriteLine("Enter the amount");
                        amount = Console.ReadLine();
                        amount1 = Convert.ToInt32(amount);
                        accounts[i].deposite(amount1);
                        break;
                    }


                    else if (temp4 == "withdraw") //Withdraw
                    {
                        Console.WriteLine("Enter your amount :");
                        amount2 = Console.ReadLine();
                        amount3 = Convert.ToInt32(amount2);


                        if (accounts[i].AccountType == 1)
                        {

                            accounts[i].withdraw(amount3);
                        }
                        else
                        {
                            accounts[i].withdraw(amount3);
                            break;
                        }
                    }

                    else if (temp4 == "transfer")  //Transfer
                    {
                        Console.WriteLine("Enter account number:");
                        var amount6 = Console.ReadLine();

                        Console.WriteLine("Enter your ammount");
                        amount4 = Console.ReadLine();
                        amount5 = Convert.ToInt32(amount4);
                        for (int j = 0; j < count; j++)
                        {
                            if (accounts[j].AccountNumber == amount6)
                            {
                                accounts[i].Transfer(accounts[j], amount5);
                                break;
                            }

                        }
                    }


                    else if (temp4 == "change")  //Change owner name
                    {   
                        Console.WriteLine("Enter The name : ");
                        name = Console.ReadLine();
                        accounts[i].AccountName = name;
                    }

                    else if (temp4 == "show") // Show Number of transaction 
                    {
                        PrintAccount(accounts[i].AccountNumber);
                    }
                }
            }
        }
    }
}
