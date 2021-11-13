using System;

namespace ExamAssignment
{
    public class InsufficientCreditsException : Exception
    {
        public InsufficientCreditsException(User user, Product product)
        {
            Console.WriteLine("User " + user.ToString() + " has not enough money to buy " + product.ToString());
        }
    }
}