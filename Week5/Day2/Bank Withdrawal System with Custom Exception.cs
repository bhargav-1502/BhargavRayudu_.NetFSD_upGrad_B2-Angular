using System;

namespace Week5Day2
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        private double balance;
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
            }

            balance -= amount;
            Console.WriteLine("Withdrawal successful!");
            Console.WriteLine("Remaining Balance: " + balance);
        }
    }

    internal class Bank_Withdrawal_System_with_Custom_Exception
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Withdraw Amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            BankAccount account = new BankAccount(balance);

            try
            {
                account.Withdraw(withdrawAmount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction process completed.");
            }
        }
    }
}

