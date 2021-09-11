using System;

namespace Exercise123
{
    public class PrintPerson
    {
        public void print(Person p)
        {
            Console.WriteLine("Navn: " + p.Fornavn + " " + p.Efternavn + " Alder: " + p.alder + " ID: " + p.PersonID);
            if (p.Mor != null)
            {
                print(p.Mor);  
            }

            if (p.Far != null)
            {
                print(p.Far);
            }
        }
    }
}