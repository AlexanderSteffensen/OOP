using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Make="Skoda", Model = "Fabia", Price = 50000},
                new Car(){Make="Skoda", Model = "Octavia", Price = 60000},
                new Car(){Make="Opel", Model="Astra", Price = 10000}
            };

            cars.Sort();
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}