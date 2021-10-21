using System;

namespace Exercise_3
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        {
            Console.WriteLine("The balance cannot be negative!");
        }
    }
}