using System;

namespace ExamAssignment
{
    public class InsertCashTransaction : Transaction, TransactionMethods 
    {
        public InsertCashTransaction(int id, User user, DateTime date, decimal amount) : base(id, user, date, amount)
        {
            User = user;
        }
        
        public string ToString()
        {
            return "InsertCashTransaction:" + ID + " " + User + " " + Amount + " " + Date;
        }

        public void Execute()
        {
            User.Balance += Amount;
        }
    }
}