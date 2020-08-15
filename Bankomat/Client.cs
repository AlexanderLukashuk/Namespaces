using System;
using ClassBank;

namespace User
{
    public class Client
    {
        public string Name { get; set; }
        public Bank bank { get; set; }
        public Client()
        {
            bank = new Bank();
            Console.WriteLine($"Welcome to {bank.Name}");
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {Name}");
            Console.WriteLine("Now your bank account will be created");
            Console.ReadLine();
            Console.WriteLine($"Your account number: {bank.BankClient.AccountNumber}");
            Console.WriteLine($"Your account password: {bank.BankClient.AccountPassword}");
            Console.WriteLine("Do not tell anyone your password");
            Console.ReadLine();
        }
    }
}