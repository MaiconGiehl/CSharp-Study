using System;
using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();


            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the account owner's name: ");
            string owner = Console.ReadLine();

            Console.Write("Do you want to put money in your account (y/n)? ");
          
            account = new Account(number, owner);

            if(Console.ReadLine() == "y")
            {
                Console.Write("Enter the deposit amount: ");
                account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine("");
            Console.WriteLine("Account information: " + account);
            Console.WriteLine("");

            Console.Write("Enter a deposit amount: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));


            Console.WriteLine("");
            Console.WriteLine("Updated account information: " + account);
            Console.WriteLine("");

            Console.Write("Enter a value to withdraw: ");
            account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("");
            Console.WriteLine("Updated account information: " + account);
        }
    }
}