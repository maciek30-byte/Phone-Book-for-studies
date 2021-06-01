namespace PhoneBook
//add validation input parameters//
// add some try catch//
// add delete contat functionality//


{
    using System;
    using PhoneBook.Components;

    internal class Program
    {
        internal static void Main(string[] args)
        {

            Console.WriteLine("Welcome to console Phone Book!!!!!!!!!!!");
            Console.WriteLine("We have several functionality to do");
            Console.WriteLine("1.Add Contact to List");
            Console.WriteLine("2. Show details about Contact");
            Console.WriteLine("Show all Contacts");
            Console.WriteLine("4.Filtred Contact by phrase");
            Console.WriteLine(" If you want Close app press c");

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
                        Console.WriteLine(" Contact successfuly Added");
                        break;

                    case "2":
                        Console.WriteLine("Insert Contact Name");
                        string contactName = Console.ReadLine();
                        defaultBook.DisplayContact(contactName);
                        break;

                    case "3":
                        defaultBook.DisplayAllContactsInList();

                        break;

                    case "4":
                        Console.WriteLine("insert Phrase To Search");
                        string phrase = Console.ReadLine();
                        defaultBook.FindContact(phrase);

                        break;
                    case "c":
                        return;
                    default:
                        Console.WriteLine("We have only four options to chosse");
                        break;
                }
                Console.WriteLine("Select Functionality");
                userInput = Console.ReadLine();
            }
        }
    }
}
