using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Program
    {

       static double balance = 1000; 

            static void Main()
            {
                while (true)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                CheckBalance();
                                break;
                            case 2:
                                DepositMoney();
                                break;
                            case 3:
                                WithdrawMoney();
                                break;
                            case 4:
                                Console.WriteLine("Thank you for using the ATM. Goodbye!");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            static void CheckBalance()
            {
                Console.WriteLine($"Your current balance is: ${balance}");
            }

            static void DepositMoney()
            {
                Console.Write("Enter the amount to deposit: $");
                double amount;
                if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a valid positive number.");
                }
            }

            static void WithdrawMoney()
            {
                Console.Write("Enter the amount to withdraw: $");
                double amount;
                if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
                {
                    if (amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds. Withdrawal failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a valid positive number.");
                }
            }
        }
    } 
    

