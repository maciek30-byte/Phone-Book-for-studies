using System;
using PhoneBook.Components;
using System.Linq;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact maciek = new Contact("Maciek", "Opozda", "531-256-638");
            Contact piotrek = new Contact("Piotrek", "Srotrek", "534-928-511");
            Contact wiesiek = new Contact("Wiesiek", "Koleszka", "424-928-913");
            Contact gerw = new Contact("Gerwazy", "Nowak", "641-343-912");
            PBook maciejList = new PBook();
            maciejList.AddContact(piotrek);
            maciejList.AddContact(wiesiek);
            maciejList.AddContact(gerw);
            Console.WriteLine(maciejList.allContacts.Count);













        }


    }
}
