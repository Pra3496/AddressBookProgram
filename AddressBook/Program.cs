﻿namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Application");
           
            AddressBook addressBook= new AddressBook();

            addressBook.createContact();

            addressBook.displayContacts();
        }
    }
}