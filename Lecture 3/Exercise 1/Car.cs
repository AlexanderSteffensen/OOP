using System;

namespace Exercise_1
{
    public class Car : IComparable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int CompareTo(Car other)
        {
            CompareCars carcomp = new CompareCars();
            return carcomp.Compare(this, other);
        }
    }
}