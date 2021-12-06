using System;

namespace DashSystem.Core.Transactions
{
    public abstract class Transaction : ITransaction
    {
    public Transaction(int id, User user, DateTime date, decimal amount)
    {
        ID = id;
        User = user;
        Date = date;
        Amount = amount;
    }

    protected int ID { get; }
    public User User { get; protected set; }
    public DateTime Date;
    public decimal Amount { get; }

    public override string ToString()
    {
        return string.Format($"Transaction id: {ID} User: {User.Username} Amount: {Amount} Date: {Date}");
    }

    public virtual void Execute()
    {
        throw new NotImplementedException();
    }
    }
}