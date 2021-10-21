using System;

namespace Exercise_4
{
    public class IllegalGearChangeException : Exception
    {
        public IllegalGearChangeException()
        {
            Console.WriteLine("Illegal gear change!");
        }
    }
}