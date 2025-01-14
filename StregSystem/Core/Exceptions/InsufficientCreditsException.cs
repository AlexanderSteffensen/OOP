using System;

namespace Core
{
    public class InsufficientCreditsException : Exception
    {
        public InsufficientCreditsException(User user, Product product)
        {
            User = user;
            Product = product;
        }

        public User User;

        public Product Product;
    }
}