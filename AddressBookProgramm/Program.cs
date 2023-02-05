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
                Console.WriteLine("Enter\n1. Add a New contact \n2. Diplay all Contacts");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        address.Display();
                        break;                  
                }
            }
        }
    }
}
