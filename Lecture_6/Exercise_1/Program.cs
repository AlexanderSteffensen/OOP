using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 4, 5 };
            Console.WriteLine(HandyMethods.Max(list));
            Console.WriteLine(HandyMethods.Min(list));

            int[] tal = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tal2 = new int[10] { 10,9,2,4,5,6,7,5,54,3 };

            tal2 = HandyMethods.Copy(tal, tal2);

            foreach (var item in tal2)
            {
                Console.WriteLine(item);
            }

            tal = HandyMethods.Shuffle(tal);

            foreach (var item in tal)
            {
                Console.WriteLine("HELLO " + item);
            }

        }
    }
}