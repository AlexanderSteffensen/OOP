using System;

namespace Exercise123
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Alexander = new Person("Alexander", "Steffensen", 20, 
                new Person("Connie", "Steffensen", 52), 
                new Person("Henry", "Steffensen", 50));

            PrintPerson print = new PrintPerson();
            print.print(Alexander);
        }
    }
}