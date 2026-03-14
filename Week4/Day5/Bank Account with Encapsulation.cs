using System;

namespace Week4Day5
{
    class BankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    internal class Bank_Account_with_Encapsulation
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.Deposit(1500);
            account.Withdraw(500);

            Console.WriteLine("Current Balance = " + account.GetBalance());
        }
    }
}

