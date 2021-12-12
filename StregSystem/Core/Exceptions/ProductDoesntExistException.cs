using System;

namespace Core.Exceptions
{
    public class ProductDoesntExistException : Exception
    {
        public ProductDoesntExistException(int id)
        {
            Id = id;
        }

        public int Id;
    }
}