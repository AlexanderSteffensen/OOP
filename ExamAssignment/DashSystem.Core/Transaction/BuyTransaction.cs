using System;

namespace ExamAssignment
{
    public class BuyTransaction : Transaction, ITransaction
    {
        public BuyTransaction(int id, User user, DateTime date, Product product) : base(id, user, date, product.Price)
        {
            Product = product;
        }

        public Product Product { get; }

        public override void Execute()
        {
            if (Product.CanBeBoughtOnCredit || User.Balance - Amount >= 0)
            {
                User.Balance -= Amount;
            }
            else
            {
                throw new InsufficientCreditsException(User, Product);
            }
        }
    }
}