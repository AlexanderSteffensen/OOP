using System;
using Core.Exceptions;

namespace Core.Transactions
{
    public class BuyTransaction : Transaction
    {
        public BuyTransaction(int id, User user, DateTime date, Product product, int amount) : base(id, user, date, amount * product.Price)
        {
            if (!product.Active)
            {
                throw new ProductNotActiveException(product);
            }
            Product = product;
            _amount = amount;
        }

        private int _amount;
        
        public Product Product { get; }

        public override void Execute()
        {
            if (Product.CanBeBoughtOnCredit || User.Balance - Price * _amount >= 0)
            {
                User.Balance -= Price * _amount;
            }
            else
            {
                throw new InsufficientCreditsException(User, Product);
            }
        }
    }
}