using System;

namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            /* --Exercise 1 --
 
             a. There is an error because it is not single quotation
             b. There is an error because a bool only takes true or false
             c. There is an error because int type does not take floating point numbers.
             d. There is an error because it needs the decimal suffix which is M, so it should be d = 6.7M;
             e  There is an error because it uses double quotation inside double quotation.
             The program thinks the string has ended right before Holger.
            */

            /* --Exercise 2--

            double radToDeg(double rad)
            {
                return (180 / Math.PI) * rad;
            }
            
            Console.WriteLine(radToDeg(10.00));

            double degToRad(double deg)
            {
                return deg * (Math.PI / 180);
            }

            Console.WriteLine(degToRad(360.00));
            
            */

            /* --Exercise 3-- 

            void printTriangle(int height)
            {
                int i;
                for (i = 1; i <= height; i++)
                {
                    Console.WriteLine(new string('*', i)); 
                }
            }
            
            printTriangle(5);
            
            */

            /* --Exercise 4-- 

            void printReverseTriangle(int height)
            {
                int i;
                for (i = height; i > 0; i--)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            
            printReverseTriangle(5);
            
            */

            /* --Exercise 5-- 

            void sqrtNum()
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();
                double num = double.Parse(input);
                Console.WriteLine(Math.Sqrt(num));
            }

            sqrtNum();
            
            */

        }
    }
}