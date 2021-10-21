using System;

namespace Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please type an integer");
            
            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("You wrote" + num);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
            
        }
    }
}