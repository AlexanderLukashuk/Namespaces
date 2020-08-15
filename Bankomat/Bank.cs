using AccountBank;

namespace ClassBank
{
    public class Bank
    {
        public string Name { get; set; }
        public int BankAccount { get; set; }
        public Account BankClient { get; set; }

        public Bank()
        {
            Name = "Kaspi";
            BankAccount = 0;
            BankClient = new Account();
        }
    }
}