namespace PhoneBook
{
    using PhoneBook.Components;
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {

            ShowUserMessage();

            PBook defaultBook = new PBook();
            var userInput = Console.ReadLine();

            while (true)
            // infinity loop while user closed  app//
            {
                switch (userInput)
                {
                    // add  try catch to fast validation//

                    case "1":
                        Console.WriteLine("Insert Contact Name");
                        string inputName = Console.ReadLine();
                        Console.WriteLine("Insert Surname");
                        string inputSurname = Console.ReadLine();
                        Console.WriteLine("Insert Phone Number by xxx-xxx-xxx");
                        string phoneNumber = Console.ReadLine();
                        Contact createdContact = new Contact(inputName, inputSurname, phoneNumber);
                        defaultBook.AddContact(createdContact);
                        Console.Clear();
                        Console.WriteLine(" Contact successfuly Added");

                        break;

                    case "2":
                        Console.WriteLine("Insert Contact Name");
                        string contactName = Console.ReadLine();
                        defaultBook.DisplayContact(contactName);

                        break;

                    case "3":
                        defaultBook.DisplayAllContactsInList();

                        // validate List length//
                        // check//


                        break;

                    case "4":
                        Console.WriteLine("insert Phrase To Search");
                        string phrase = Console.ReadLine();
                        defaultBook.FindContact(phrase);
                        break;
                    case "5":
                        Console.WriteLine("Insert Contact name to delete");
                        string nameToDelete = Console.ReadLine();
                        defaultBook.DeleteContact(nameToDelete);


                        break;
                    case "c":
                        return;
                    default:
                        Console.WriteLine("We have only four options to chosse");
                        break;
                }
                Console.WriteLine("Select Functionality");
                ShowUserMessage();
                userInput = Console.ReadLine();



            }
            void ShowUserMessage()
            {
                Console.WriteLine("Welcome to console Phone Book!!!!!!!!!!!");
                Console.WriteLine("We have several functionality to do");
                Console.WriteLine("1. Add Contact to List");
                Console.WriteLine("2. Show details about Contact");
                Console.WriteLine("3. Show all Contacts");
                Console.WriteLine("4. Filtred Contact by phrase");
                Console.WriteLine("5. Delete Contact by name");
                Console.WriteLine(" If you want Close app press c");
            }
        }
    }
}
