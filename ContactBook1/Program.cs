using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactBook1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactBook contactBook = new ContactBook();
            Console.WriteLine("Hello There... \nPlease choose from the menu below.");

            while (true)
            {
                Console.WriteLine("\n--- Contact Book Menu ---");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Remove an existing contact");
                Console.WriteLine("3. Find a contact by name");
                Console.WriteLine("4. List all contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string nameToAdd = Console.ReadLine();

                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Console.WriteLine(contactBook.AddContact(nameToAdd, phoneNumber));
                        break;

                    case "2":
                        Console.Write("Enter name to remove: ");
                        string nameToRemove = Console.ReadLine();

                        Console.WriteLine(contactBook.RemoveContact(nameToRemove));
                        break;

                    case "3":
                        Console.Write("Enter name to find: ");
                        string nameToFind = Console.ReadLine();

                        Console.WriteLine(contactBook.FindContactByName(nameToFind));
                        break;

                    case "4":
                        contactBook.ListAllContacts();
                        break;

                    case "5":
                        contactBook.ExitProgram();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }

            }

        }
    
    
    
    }
}
