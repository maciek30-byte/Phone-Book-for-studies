using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Components
{
    class PBook
    {
        public List<Contact> allContacts = new List<Contact>();

        public void AddContact(Contact newContact)
        {
            allContacts.Add(newContact);
        }

        private void ShowAllInformationAboutContact(Contact contact)
        {
            Console.WriteLine($"Contact name and surname is {contact.Name} {contact.Surname} and Phone Number {contact.PhoneNumber} ");
        }

        public void DisplayContact(string Name)
        {
            var contact = allContacts.FirstOrDefault(c => c.Name == Name);
            // return first matched contact, if do not exist return null //
            if (contact == null)
            {
                Console.WriteLine("Contact is not exist");
            }
            else
            {
                ShowAllInformationAboutContact(contact);

            }


            // try that conditions fire without else statment//

        }

        public void DisplayAllContactsInList()
        {
            foreach (var contact in allContacts)
            {
                ShowAllInformationAboutContact(contact);
            }

        }

        public void FindContact(string phrase)
        {
            var filtredList = allContacts.Where(c => c.Name.Contains(phrase)).ToList();

            //Where methods filter list and return value matched to predicate//
            // To.List assinged matched values To list and convert our variable to that//

        }
    }
}
