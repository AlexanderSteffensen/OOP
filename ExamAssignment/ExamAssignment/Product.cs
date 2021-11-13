using System.Security.Cryptography;

namespace ExamAssignment
{
    public class Product
    {
        public Product(int id, string name, decimal price, bool active)
        {
            ID = id;
            Name = name;
            Price = price;
            Active = active;
        }

        private int ID;
        private string Name;
        public decimal Price { get; }
        private bool Active;
        public bool CanBeBoughtOnCredit { get; private set; }



        public string ToString()
        {
            return ID + ". " + Name + " " + Price;
        }

        



    }
}