using System;

namespace ExamAssignment
{
    public class BuyTransaction : Transaction, TransactionMethods
    {
        public BuyTransaction(int id, User user, DateTime date, Product product) : base(id, user, date, product.Price)
        {
            _product = product;
        }

        private Product _product;
        
        public string ToString()
        {
            return  "BuyTransaction:" + ID + " " + User + " " + Amount + " " + Date;
        }

        public void Execute()
        {
            if (_product.CanBeBoughtOnCredit || User.Balance - Amount >= 0)
            {
                User.Balance -= Amount;
            }
            else
            {
                throw new InsufficientCreditsException(User, _product);
            }
        }
    }
}