using System;
using System.Collections.Generic;

namespace Exercise_4
{
    delegate T Join<T>(T one, T second);
    class Program
    {
        static void Main(string[] args)
        {
            T JoinList<T>(List<T> list, Join<T> join)
            {
                T result = list[0];
                for (int i = 1; i < list.Count; i++)
                    result = join(result, list[i]);
                return result;
            }

            Console.WriteLine(JoinList(new List<string>{"Hello ", "Team ", "What ", "Is ", "Goin ", "On?"},
                (one, second) => one + second ));
            Console.WriteLine(JoinList(new List<int>{1,2,3,4,5,6,7,8,9,10},
                (one, second) => one + second ));
            
            
            
        }
    }
}