using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Components
{
    class Contact
    {
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;

        }
        public string Name { get; set; }
        public string Surname;
        public string PhoneNumber { get; set; }
    }
}
