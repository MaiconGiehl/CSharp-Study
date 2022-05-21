using System;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the account owner's name: ");
            string owner = Console.ReadLine();

            Console.Write("Do you want to put money in your account (y/n)? ");
            char answer = char.Parse(Console.ReadLine());

            if(answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter the deposit amount: ");
                double firstDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, owner, firstDeposit);
            } else
            {
                account = new Account(number, owner);
            }

            Console.WriteLine("");
            Console.WriteLine("Account information: " + account);
            Console.WriteLine("");

            Console.Write("Enter a deposit amount: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);

            Console.WriteLine("");
            Console.WriteLine("Updated account information: " + account);
            Console.WriteLine("");

            Console.Write("Enter a value to withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);
            
            Console.WriteLine("");
            Console.WriteLine("Updated account information: " + account);
        }
    }
}