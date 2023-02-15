using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        Contact contact = new Contact();

        public void createContact()
        {
            Console.Write("Enter the First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.Write("\nEnter the Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.Write("\nEnter the State : ");
            contact.State = Console.ReadLine();
            Console.Write("\nEnter the City : ");
            contact.City = Console.ReadLine();
            Console.Write("\nEnter the Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("\nEnter the Address : ");
            contact.Address = Console.ReadLine();
            Console.Write("\nEnter the Zip Code Name : ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
        }
        public void displayContacts()
        {

            Console.WriteLine("\nContatct Details\nFirst Name   :\t{0}\nLast Name    :\t{1}\nAddress      :\t{2}\nCity         :\t{3}\nState        :\t{4}\nPhone Number :\t{5},\nZip Code     :\t{6}",contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.PhoneNumber, contact.Zip);
        }
    }
}
