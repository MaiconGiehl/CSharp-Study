using System;
using System.Globalization;

namespace BankAccount
{
    class Account
    {
        public int Number { get; private set; }
        public string Owner { get; set; }
        public double Balance { get; private set; }


        public Account(int number, string owner)
        {
            Number = number;
            Owner = owner;
            Balance = 0;

        }
        public Account(int number, string owner, double firstDeposit) : this(number, owner)
        {
            Deposit(firstDeposit);
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw (double amount)
        {
            Balance -= amount;
            Balance -= 5.0;
        }
        
        public override string ToString()
        {
            return $"Account {Number}, " +
                $"Owner {Owner}, " +
                $"Balance ${Balance.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}