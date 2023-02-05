using System;

namespace AddressBookProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter\n1. Add a New contact \n2. Diplay all Contacts\n3. Edit a contact");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        address.Display();
                        break;
                    case 3:
                        address.EditContact();
                        Console.WriteLine("Enter Details to change As you Want :");
                        address.AddContact();
                        break;
                }
            }
        }
    }
}
