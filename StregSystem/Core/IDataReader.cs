using System.Collections.Generic;

namespace Core
{
    public interface IDataReader
    {
        public List<User> GetUsers();
        public List<Product> GetProducts();
    }
}