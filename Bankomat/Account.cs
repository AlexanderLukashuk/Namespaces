using System;

namespace AccountBank
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public int AccountPassword { get; set; }

        public Account()
        {
            Random rnd = new Random();
            AccountNumber = 8 + rnd.Next(10);
            AccountPassword = 8 + rnd.Next(100);
        }
    }
}