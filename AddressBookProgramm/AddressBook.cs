using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgramm
{
    internal class AddressBook
    {
        public List<Contact> Contacts;
        public AddressBook()
        {
            Contacts = new List<Contact>();
        }
        public void AddContact()
        {
            var contact = new Contact();
            Console.WriteLine("Enter First Name :");
            contact.First_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            contact.Last_name = Console.ReadLine();
            Console.WriteLine("Enter City :");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State :");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Postal ZipCode :");
            contact.Postal_Zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contact Number :");
            contact.Contact_Number = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email Id :");
            contact.Email_Id = Console.ReadLine();
            Contacts.Add(contact);
            Console.WriteLine("Contact Details Entered Successfully : ");
        }              
    }
}
