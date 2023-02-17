using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        private Contact contact;

        private string[] editOptions = { "  First Name  ", "  Last Name  ", "  Address  ", "  City  ", "  State  ", "  Phone Number  ", "  Zip Code  ","  Email  " };
    


        List<Contact> contactList = new List<Contact>();

        public void createContact()
        {

            contact = new Contact();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the First Name : ");
            Console.CursorLeft = 78;
            contact.FirstName = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the Last Name");
            Console.CursorLeft = 78;
            contact.LastName = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the Phone Number");
            Console.CursorLeft = 78;
            contact.PhoneNumber = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the Email");
            Console.CursorLeft = 78;
            contact.Email = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the Address");
            Console.CursorLeft = 78;
            contact.Address = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the City Name");
            Console.CursorLeft = 78;
            contact.City = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter the State");
            Console.CursorLeft = 78;
            contact.State = Console.ReadLine();
            Console.CursorLeft = 78;
            Console.WriteLine("Enter Zip Code");
            Console.CursorLeft = 78;
            contact.Zip = Convert.ToInt64(Console.ReadLine());

            contactList.Add(contact);
        }
        public void displayContacts()
        {
            int iCnt = 0;

            if (contactList.Count == 0) 
            {
                Console.CursorLeft = 78;
                Console.WriteLine("\tNo Contacts To Display........!!!!"); 
            }
            else 
            {
                
                Console.CursorLeft = 82;
                Console.WriteLine("\t-: Contact Details :-");
                foreach (Contact sample in contactList)
                {
                    Console.CursorLeft = 78;
                    Console.Write("-----------------[" + ++iCnt + "]----------------\n");
                    Console.CursorLeft = 80;
                    Console.WriteLine();
                    Console.CursorLeft = 80;
                    Console.WriteLine("First Name   :\t"+sample.FirstName);
                    Console.CursorLeft = 80;
                    Console.WriteLine("Last Name    :\t"+sample.LastName);
                    Console.CursorLeft = 80;
                    Console.WriteLine("Address      :\t"+sample.Address);
                    Console.CursorLeft = 80;
                    Console.WriteLine("City         :\t"+sample.City);
                    Console.CursorLeft = 80;
                    Console.WriteLine("State        :\t"+sample.State);
                    Console.CursorLeft = 80;
                    Console.WriteLine("Phone Number :\t"+sample.PhoneNumber);
                    Console.CursorLeft = 80;
                    Console.WriteLine("Zip Code     :\t"+sample.Zip);
                    Console.CursorLeft = 80;
                    Console.WriteLine("Email        :\t"+sample.Zip);
                    Console.CursorLeft = 78;
                    Console.Write("-------------------------------------\n");
                }
                
            }
           
        }

        public void EditDetails()
        {
            bool input = true, chk = true;
            if (contactList.Count < 1)
            {
                Console.WriteLine("\n\tNo Contacts To Edit");
            }
            else
            {
                Console.WriteLine();
                Console.CursorLeft = 78;
                Console.WriteLine("Enter name of person in contact to be edited :");
                Console.CursorLeft = 78;
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
                                
                                Console.WriteLine();
                                Console.CursorLeft = 78;
                                Console.Write("Choose Option to Edit Contact\n");
                                Console.CursorLeft = 78;
                                string opy = "------------{ Edit Contacts }------------";

                                MainMenu menu = new MainMenu(editOptions,opy);
                                int option = menu.Run();
                                switch (option)
                                {
                                    case 0:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter First name : ");
                                        Console.CursorLeft = 103;
                                        string currentFirstName = Console.ReadLine();
                                        sample.FirstName = currentFirstName;
                                        input = false;
                                        Console.CursorLeft = 85;
                                        Console.WriteLine();
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 1:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter Last name : ");
                                        Console.CursorLeft = 103;
                                        string currentLastName = Console.ReadLine();
                                        sample.LastName = currentLastName;
                                        input = false;
                                        Console.CursorLeft = 85;
                                        Console.WriteLine();
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 2:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter address : ");
                                        Console.CursorLeft = 103;
                                        string currentAddress = Console.ReadLine();
                                        sample.Address = currentAddress;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 3:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter city : ");
                                        Console.CursorLeft = 103;
                                        string currentCity = Console.ReadLine();
                                        sample.City = currentCity;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 4:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter state : ");
                                        Console.CursorLeft = 103;
                                        string currentState = Console.ReadLine();
                                        sample.State = currentState;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 5:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter phone number : ");
                                        Console.CursorLeft = 103;
                                        string currentPhoneNumber = Console.ReadLine();
                                        sample.PhoneNumber = currentPhoneNumber;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 6:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter zip code : ");
                                        Console.CursorLeft = 103;
                                        long currentZip = Convert.ToInt64(Console.ReadLine());
                                        sample.Zip = currentZip;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 7:
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.Write("Enter Email id : ");
                                        Console.CursorLeft = 103;
                                        string currentEmail = Console.ReadLine();
                                        sample.Email = currentEmail;
                                        input = false;
                                        Console.WriteLine();
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    default:
                                        Console.CursorLeft = 85;
                                        Console.WriteLine("Enter Proper Option.....!!");
                                        break;
                                }

                            }
                        }
                    }
                }
                else
                { Console.WriteLine(); Console.CursorLeft = 85; Console.WriteLine("\tThe person is not found"); }
            }

        }

        public void deleteContact()
        {
            
            char per = '\0';
            bool chk = true;
            if (contactList.Count < 1)
            {
                Console.CursorLeft = 78;
                Console.WriteLine("\tNo Contacts To Remove");
            }
            else
            {
                Console.CursorLeft = 78;
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
                            Console.WriteLine();
                            Console.CursorLeft = 78;
                            Console.Write("Do You Want To Remove Contact (Y/N) : ");
                            per = Console.ReadKey().KeyChar;
                            if (per == 'Y' || per == 'y')
                            {
                                
                                contactList.Remove(sample);
                                Console.WriteLine("\n\n");
                                Console.CursorLeft = 78;
                                Console.WriteLine("\tCONTACT REMOVE SUCESSFULLY..!!!");
                            }
                            
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.CursorLeft = 78; Console.WriteLine("The person is not found"); }
            }


        }

    }
}
            
           
                
