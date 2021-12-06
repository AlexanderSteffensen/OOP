using System;

namespace DashSystem.Core
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

        public int ID;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value == null)
                {
                    throw new Exception("Product name cannot be null");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public decimal Price { get; }
        public bool Active { get; private set; }
        public bool CanBeBoughtOnCredit { get; private set; }
        
        public override string ToString()
        {
            return ID + ". " + Name + " " + Price;
        }

        public void Activate()
        {
            Active = true;
        }
        
        public void Deactivate()
        {
            Active = false;
        }

        public void CreditOn()
        {
            CanBeBoughtOnCredit = true;
        }
        
        public void CreditOff()
        {
            CanBeBoughtOnCredit = false;
        }



    }
}