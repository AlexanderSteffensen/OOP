using System;

namespace Exercise_3
{
    public class BankAccount
    {
        public BankAccount(double balance)
        {
            if (balance < 0)
                throw new InsufficientFundsException();
            else
            {
                _balance = balance;
            }
            
        }

        private double _balance;

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount < 0)
                throw new InsufficientFundsException();
            else
            {
                _balance -= amount;
                Console.WriteLine("You successfully withdraw " + amount);
            }
        }
    }
}