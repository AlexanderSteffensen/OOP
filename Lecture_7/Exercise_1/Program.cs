using System;

namespace Exercise_1
{
    delegate string StringJoin(string l, string r);
    class Program
    {
        static void Main(string[] args)
        {
            string ConcatString(string l, string r) { return l + r; }
            
            StringJoin joinStrings = ConcatString;

            Console.WriteLine(joinStrings("Hello ", "delegate"));
            
            
            
        }
    }
}