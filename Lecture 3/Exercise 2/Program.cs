using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITaxable> things = new List<ITaxable>();
            
            things.Add(new Bus(100, 12934, 600000));
            things.Add(new House("Aalborg", true, 1000, 900000));
            foreach (ITaxable thing in things)
            {
                Console.WriteLine(thing.TaxValue());
            }
        }
    }
}