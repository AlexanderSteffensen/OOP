using System;

namespace Core.Transactions
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(int id, User user, DateTime date, decimal price) : base(id, user, date, price)
        {
            User = user;
        }
        public override void Execute()
        {
            User.Balance += Price;
        }
    }
}