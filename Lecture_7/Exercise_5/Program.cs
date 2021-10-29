using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Exists<T>(Predicate<T> f, T[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (f(a[i]))
                    {
                        return true;
                    }
                }
                return false;
            }

            Console.WriteLine(Exists((a) => a == 2, new int[] {1,3,4,5,6,7,8,9}));
            
        }
    }
}