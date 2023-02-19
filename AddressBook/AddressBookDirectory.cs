﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookDirectory
    {
        private AddressBook addressbook;


        List<AddressBook> directoryList = new List<AddressBook>();

        public void createAddressBook()
        {

            addressbook = new AddressBook();
            Console.Write("Enter the Name of Addreess Book : ");
            addressbook.name = Convert.ToString(Console.ReadLine());
            directoryList.Add(addressbook);
        }
        public void displayDirectory()
        {
            int iCnt = 0;

            if (directoryList.Count == 0)
            {
                Console.WriteLine("\tNo Address Book To Display........!!!!");
            }
            else
            {
                Console.WriteLine("\t-: Contact Details :-");
                foreach (AddressBook sample in directoryList)
                {
                    Console.Write("-----------------[" + ++iCnt + "]----------------\n");
                    Console.WriteLine("\nName of Address Book : " + sample.name);
                    Console.Write("-------------------------------------\n");
                }
                


            }

        }

        public void renameAddressBook()
        {
            if (directoryList.Count < 1)
            {
                Console.WriteLine("\n\tNo Contacts To Edit");
            }
            else
            {
                Console.Write("Enter name of person in contact to be edited : ");
                string name = Console.ReadLine();
                foreach (AddressBook sample in directoryList)
                {
                    if (sample.name == name)
                    {
                        Console.WriteLine("Found Addressbook...!!!");
                        Console.Write("Enter New Name : ");
                        string currentFirstName = Console.ReadLine();
                        sample.name = currentFirstName;
                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                        break;
                    }
                }

            }

        }

        public void deleteAddressBook()
        {

            char per = '\0';
            bool chk = false;
            string name;
            if (directoryList.Count < 1)
            {
                Console.WriteLine("\n\tNo Contacts To Remove");
            }
            else
            {
                Console.Write("Enter name of Address Book in Directory to be Remove : ");
                name = Convert.ToString(Console.ReadLine());
                foreach (AddressBook sample in directoryList)
                {
                    if (sample.name == name)
                    {
                        Console.Write("\nDo You Want To Remove {0} Address book (Y/N) : ",name);
                        per = Console.ReadKey().KeyChar;
                        if (per == 'Y' || per == 'y')
                        {

                            directoryList.Remove(sample);
                            Console.WriteLine("\n\n\tADDRESS BOOK REMOVE SUCESSFULLY..!!!");
                        }
                        chk = true;
                        break;

                    }
                    
                }
                if(chk == false)
                {
                     Console.WriteLine("\nThe {0} Address Book is not found", name);
                }
                

            }

          
        }

        public void selectAddressBookForOperation()
        {
            bool flag = false;
            
            Console.WriteLine("\nPerform CRUD operations on Selected Address Book\n");

            Console.Write("Enter name of Address Book : ");

            string name = Console.ReadLine();

            foreach (AddressBook sample in directoryList)
            {
                if(sample.name == name) 
                {
                    sample.run();
                    flag = true;
                    break;
                }
                
            }

            if(flag == false)
            {
                Console.WriteLine("\nThe {0} Address Book is not found",name);
            }


        }
    }
}
