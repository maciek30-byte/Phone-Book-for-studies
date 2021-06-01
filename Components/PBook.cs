namespace PhoneBook.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PBook
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

        private void ShowAllInformationsAboutContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                ShowAllInformationAboutContact(contact);
            }
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
                // single contact details
            }
        }

        public void DisplayAllContactsInList()
        {
            ShowAllInformationsAboutContacts(allContacts);
        }

        public void FindContact(string phrase)
        {
            var filtredList = allContacts.Where(c => c.Name.Contains(phrase)).ToList();
            // contains we couuld match a piece of phrase, and convert to list, that we used in SAIACs function
            ShowAllInformationsAboutContacts(filtredList);
        }
    }
}
