using System;

namespace ExamAssignment
{
    public abstract class Transaction
    {
        public Transaction(int id, User user, DateTime date, decimal amount)
        {
            ID = id;
            User = user;
            Date = date;
            Amount = amount;
        }

        protected int ID { get; }
        protected User User;
        protected DateTime Date;
        protected decimal Amount;

        

        public void InsertCashTransaction()
        {
            
        }

        public void BuyTransaction()
        {
            
        }
    }
}