using System;
using System.Globalization;

namespace BankAccount
{
    class Account
    {
        private int _number;
        private string _owner;
        private double _balance;


        public Account()
        {
            _balance = 0;
            _number = 0;
            _owner = "";
        }
        public Account(int number, string owner) : this()
        {
            _number = number;
            _owner = owner;
        }


        public void Deposit (double deposit)
        {
            _balance += deposit;
        }

        public void Withdraw (double withdraw)
        {
            _balance -= (withdraw + 5);
        }
        
        public override string ToString()
        {
            return $"Account {_number}, Owner {_owner}, Balance ${_balance.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}