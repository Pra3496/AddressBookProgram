﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        private Contact contact;
        private bool chk;


        List<Contact> contactList = new List<Contact>();

        public void createContact()
        {

            contact = new Contact();
            Console.Write("Enter the First Name     : ");
            contact.FirstName = Console.ReadLine();
            Console.Write("\nEnter the Last Name    : ");
            contact.LastName = Console.ReadLine();
            Console.Write("\nEnter the Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("\nEnter the Email        : ");
            contact.Email = Console.ReadLine();
            Console.Write("\nEnter the Address      : ");
            contact.Address = Console.ReadLine();
            Console.Write("\nEnter the City Name    : ");
            contact.City = Console.ReadLine();
            Console.Write("\nEnter the State        : ");
            contact.State = Console.ReadLine();
            Console.Write("\nEnter Zip Code         : ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());

            contactList.Add(contact);
        }
        public void displayContacts()
        {
            int iCnt = 0;

            if (contactList.Count == 0) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tNo Contacts To Display........!!!!"); 
            }
            else 
            {
                Console.WriteLine("\t-: Contact Details :-");
                foreach (Contact sample in contactList)
                {
                    Console.Write("-----------------[" + ++iCnt + "]----------------\n");
                    Console.WriteLine("\nFirst Name   :\t{0}\nLast Name    :\t{1}\nAddress      :\t{2}\nCity         :\t{3}\nState        :\t{4}\nPhone Number :\t{5},\nZip Code     :\t{6}", sample.FirstName, sample.LastName, sample.Address, sample.City, sample.State, sample.PhoneNumber, sample.Zip);
                    Console.Write("-------------------------------------\n");
                }
            }
           
        }

        public void EditDetails()
        {
            bool input = true, chk = true;
            if (contactList.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\tNo Contacts To Edit");
            }
            else
            {
                Console.Write("Enter name of person in contact to be edited : ");
                string name = Console.ReadLine();
                foreach (Contact sample in contactList)
                {
                    if (sample.FirstName == name)
                    {
                        chk = false;
                        break;
                    }
                }
                if (chk == false)
                {
                    foreach (Contact sample in contactList)
                    {
                        if (sample.FirstName == name)
                        {
                            while (input)
                            {

                                Console.Write("\nChoose Option to Edit Contact\n");
                                Console.WriteLine("\n1 : First name\t2 : Last name\n3 : Address\t4 : City\n5 : State\t6 : Phone Number\n7 : zip code\t8 : E-mail id");
                                Console.Write("\nEnter Your Choice : ");
                                int option = Convert.ToInt32(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Enter First name");
                                        string currentFirstName = Console.ReadLine();
                                        sample.FirstName = currentFirstName;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter Last name");
                                        string currentLastName = Console.ReadLine();
                                        sample.LastName = currentLastName;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter address");
                                        string currentAddress = Console.ReadLine();
                                        sample.Address = currentAddress;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter city");
                                        string currentCity = Console.ReadLine();
                                        sample.City = currentCity;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\nCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 5:
                                        Console.WriteLine("Enter state");
                                        string currentState = Console.ReadLine();
                                        sample.State = currentState;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 6:
                                        Console.WriteLine("Enter phone number");
                                        string currentPhoneNumber = Console.ReadLine();
                                        sample.PhoneNumber = currentPhoneNumber;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 7:
                                        Console.WriteLine("Enter zip ocde");
                                        long currentZip = Convert.ToInt64(Console.ReadLine());
                                        sample.Zip = currentZip;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 8:
                                        Console.WriteLine("Enter Email id");
                                        string currentEmail = Console.ReadLine();
                                        sample.Email = currentEmail;
                                        input = false;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    default:
                                        Console.WriteLine("Enter Proper Option.....!!");
                                        break;
                                }

                            }
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nThe person is not found");
                }
            }

        }

        public void deleteContact()
        {
            char per = '\0';
            if (contactList.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\tNo Contacts To Remove");
            }
            else
            {
                Console.Write("Enter name of person in contact to be edited : ");
                string name = Console.ReadLine();
                foreach (Contact sample in contactList)
                {
                    if (sample.FirstName == name)
                    {
                        chk = false;
                        break;
                    }
                }
                if (chk == false)
                {
                    foreach (Contact sample in contactList)
                    {
                        if (sample.FirstName == name)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("\nDo You Want To Remove {0}  from Contact (Y/N) : ",name);
                            per = Console.ReadKey().KeyChar;
                            if (per == 'Y' || per == 'y')
                            {
                                
                                contactList.Remove(sample);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n\n\tCONTACT REMOVE SUCESSFULLY..!!!");
                            }
                            
                            break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; 
                    Console.WriteLine("\nThe person is not found");
                }
            }


        }

    }
}
            
           
                
