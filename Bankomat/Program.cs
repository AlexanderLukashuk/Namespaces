using System;
using User;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            string input;
            int password;
            int numberOfInputPasswordAttempts = 0;
            int option = 0;
            int money = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                if (numberOfInputPasswordAttempts == 3)
                {
                    Environment.Exit(0);
                }
                Console.Write("Enter password for your bank account: ");
                input = Console.ReadLine();
                password = int.Parse(input);
                if (password == client.bank.BankClient.AccountPassword)
                {
                    Console.WriteLine($"Welcome, {client.Name}");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password. Try again");
                    numberOfInputPasswordAttempts++;
                }
            }

            while (option != 4)
            {
                Console.Clear();
                Console.WriteLine("Choose option: ");
                Console.WriteLine("1) Displaying the balance on the screen");
                Console.WriteLine("2) Account funding");
                Console.WriteLine("3) Withdraw money from the account");
                Console.WriteLine("4) Exit");
                input = Console.ReadLine();
                option = int.Parse(input);
                Console.Clear();

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine($"Your bank account: {client.bank.BankAccount}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter top-up amount: ");
                            input = Console.ReadLine();
                            money = int.Parse(input);
                            client.bank.BankAccount = money;
                            Console.WriteLine($"Your bank account is credited with {money}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter the amount you want to withdraw: ");
                            input = Console.ReadLine();
                            money = int.Parse(input);
                            if (money < client.bank.BankAccount)
                            {
                                client.bank.BankAccount -= money;
                                Console.WriteLine($"You withdrew {money}");
                                Console.WriteLine($"Now your bank account: {client.bank.BankAccount}");
                            }
                            else
                            {
                                Console.WriteLine($"You can not withdraw {money}");
                                Console.WriteLine($"Your bank account: {client.bank.BankAccount}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Goodbye, {client.Name}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You chose wrong option");
                            Console.WriteLine("Try again");
                            break;
                        }
                }
                Console.ReadLine();
            }
        }
    }
}
