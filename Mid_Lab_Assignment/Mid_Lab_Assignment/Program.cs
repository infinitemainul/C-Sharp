using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Lab_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, temp1, name, dob, adress1, balance1, temp4, num, accountnumber;

            int balance2, ran = 1000;


            Bank bank = new Bank(100);

            Console.WriteLine("\t**************************************");
            Console.WriteLine("\t     D Bank Software ");
            Console.WriteLine("\t**************************************");
            for (; ; )
            {
                Console.WriteLine("Your Options :\n  \nOpen a Bank account\nPerform Transaction Account\nExit The Aplication\n");
                temp = Console.ReadLine();
                //a = Convert.ToInt32(temp);

                switch (temp)
                {
                    case "open":
                        {
                            Console.WriteLine("\nOpen Saving Account\nOpen Checking Account\nExit The Aplication\n");
                            temp1 = Console.ReadLine();

                            if (temp1 == "quit")
                            {
                                break;
                            }
                            else if (temp1 == "saving")
                            {
                                Console.WriteLine("Enter Your Name : ");
                                name = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter the Date of Birth :");
                                dob = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter the Adress :");
                                adress1 = Console.ReadLine();
                                Console.WriteLine();

                                ran++;
                                num = ran.ToString();

                                Console.WriteLine("Enter the first Balane :");
                                balance1 = Console.ReadLine();
                                balance2 = Convert.ToInt32(balance1);
                                Console.WriteLine();

                                SavingsAccount obj = new SavingsAccount(500);
                                obj.AccountName = name;
                                obj.Dob = dob;
                                obj.Adress = adress1;
                                obj.AccountNumber = num;
                                obj.Balance = balance2;
                                bank.CreateAccount(obj);

                            }
                            else if (temp1 == "checking")
                            {
                                Console.WriteLine("Enter Your Name : ");
                                name = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter the Date of Birth :");
                                dob = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("Enter the Adress :");
                                adress1 = Console.ReadLine();
                                Console.WriteLine();

                                ran++;
                                num = ran.ToString();

                                Console.WriteLine("Enter the first Balane :");
                                balance1 = Console.ReadLine();
                                balance2 = Convert.ToInt32(balance1);
                                Console.WriteLine();



                                CheckingAccount obj1 = new CheckingAccount();
                                obj1.AccountName = name;
                                obj1.Dob = dob;
                                obj1.Adress = adress1;
                                obj1.AccountNumber = num;
                                obj1.Balance = balance2;
                                bank.CreateAccount(obj1);
                            }


                            break;



                        }



                    case "account":
                        {
                            Console.WriteLine("Enter Your Account Number :");
                            accountnumber = Console.ReadLine();

                            for (; ; )
                            {
                                Console.WriteLine("\nMake a Deposit\nMake a Withdraw\nMake a Transfer\nChange owner name\nShow the account\nExit the application \n");

                                temp4 = Console.ReadLine();


                                if (temp4 == "quit")
                                {
                                    break;
                                }
                                else
                                {
                                    bank.Performtransaction(accountnumber, temp4);
                                }

                                break;
                            }
                            break;
                        }

                    case "quit":

                        return;

                    default:
                        Console.WriteLine("WRONG INPUT");

                        break;



                }


            }
        }
    }
}
