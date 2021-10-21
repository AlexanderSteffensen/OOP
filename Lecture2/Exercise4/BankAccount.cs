using System.Security.Cryptography;

namespace Exercise4
{
    public class BankAccount
    {
        private double balance;
        private double borrowingRate = 10;
        private double savingsRate = 1;

        public double SavingsRate
        {
            get
            {
                return savingsRate;
            }
            set
            {
                savingsRate = value;
            }
        }

        void Deposit(double money)
        {
            if (!Interest())
            {
                
            }
            balance += money;
        }

        double Withdraw(double money)
        {   
            
            balance -= money;
            return money;
        }

        bool Interest()
        {
            if (balance < 0)
            {
                balance = balance + (balance * borrowingRate * 0.1);
                return false;
            }
            else if (balance > 0)
            {
                balance *= savingsRate * 0.1;
            }
        }
        
    }
}