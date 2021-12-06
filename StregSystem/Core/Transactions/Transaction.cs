using System;

namespace Core.Transactions
{
    public abstract class Transaction : ITransaction
    {
    public Transaction(int id, User user, DateTime date, decimal price)
    {
        ID = id;
        User = user;
        Date = date;
        Price = price;
    }

    protected int ID { get; }
    public User User { get; protected set; }
    public DateTime Date;
    public decimal Price { get; }

    public override string ToString()
    {
        return string.Format($"Transaction id: {ID} User: {User.Username} Amount: {Price} Date: {Date}");
    }

    public virtual void Execute()
    {
        throw new NotImplementedException();
    }
    }
}