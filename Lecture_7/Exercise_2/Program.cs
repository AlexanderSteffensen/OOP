using System;
using System.Runtime.Intrinsics.X86;

namespace Exercise_2
{
    class Program
    {
        delegate string StringJoin(string s1, string s2);
        static void Main(string[] args)
        {
            
            string JoinThree(string s1, string s2, string s3, StringJoin join)
            {
                return join(join(s1, s2), s3);
            }

            Console.WriteLine(JoinThree("Hej ", "med ", "dig!", (s1, s2) => s1));
            
            
        }
    }
}