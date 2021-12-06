using System.Collections.Generic;

namespace Core.Factory
{
    public abstract class Factory<T>
    {

        public Factory()
        {
            Items = new List<T>();
            GetItems();
            
        }
        
        public virtual void GetItems()
        {}

        public List<T> Items;
    }
}