using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence test = new Sequence(2, 3, 4);

            do
            {
                Console.WriteLine(test.GetEnumerator().Current);
            } while (test.GetEnumerator().MoveNext());
        }
    }
}