using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        delegate string JoinStrings(string s1, string s2);
        static void Main(string[] args)
        {


            string JoinAllStrings(List<string> strings, JoinStrings join)
            {
                string result = "";
                foreach (string str in strings)
                {
                    result = join(result, str);
                }

                return result;
            }

            Console.WriteLine(JoinAllStrings(new List<string>{"a", "b", "c", "d"}, (s1, s2) => s1 + s2));
            
            
        }
    }
}