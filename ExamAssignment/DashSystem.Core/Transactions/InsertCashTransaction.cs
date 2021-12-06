using System;

namespace DashSystem.Core.Transactions
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(int id, User user, DateTime date, decimal amount) : base(id, user, date, amount)
        {
            User = user;
        }
        public override void Execute()
        {
            User.Balance += Amount;
        }
    }
}