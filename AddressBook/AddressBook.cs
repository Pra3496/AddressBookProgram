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

        public string name { get; set; }


        List<Contact> contactList = new List<Contact>();
        Dictionary<string, Contact> contactDict = new Dictionary<string, Contact>();

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

            if (contactDict.ContainsKey(contact.FirstName))
            {
                Console.WriteLine("\n\n\tDublicate Entry Detected...!!!!!\n\tCannot ADD");
            }
            else
            {
                contactList.Add(contact);
                contactDict.Add(contact.FirstName, contact);
                Console.WriteLine("\n\n\tCONTACT ADDED SUCESSFULLY....\n\n");

            }
        }
        public void displayContacts()
        {
            int iCnt = 0;

            if (contactDict.Count == 0) 
            {
                Console.WriteLine("\tNo Contacts To Display........!!!!"); 
            }
            else 
            {
               
                    Console.WriteLine("\t-: Contact Details :-");
                    foreach (var sample in contactDict)
                    {
                        Console.Write("-----------------[" + ++iCnt + "]----------------\n");
                        Console.WriteLine("\nFirst Name   :\t{0}\nLast Name    :\t{1}\nAddress      :\t{2}\nCity         :\t{3}\nState        :\t{4}\nPhone Number :\t{5},\nZip Code     :\t{6}", sample.Value.FirstName, sample.Value.LastName, sample.Value.Address, sample.Value.City, sample.Value.State, sample.Value.PhoneNumber, sample.Value.Zip);
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
                                Console.WriteLine("\n1:Edit first name\n2:Edit last name\n3:Edit address\n4:Edit city\n5:Edit state\n6:Edit phone number\n7:Edit zip code\n8:Edit email id");
                                Console.Write("\nEnter Your Choice : ");
                                int option = Convert.ToInt32(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Enter First name");
                                        string currentFirstName = Console.ReadLine();
                                        sample.FirstName = currentFirstName;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter Last name");
                                        string currentLastName = Console.ReadLine();
                                        sample.LastName = currentLastName;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter address");
                                        string currentAddress = Console.ReadLine();
                                        sample.Address = currentAddress;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter city");
                                        string currentCity = Console.ReadLine();
                                        sample.City = currentCity;
                                        input = false;
                                        Console.WriteLine("\n\nCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 5:
                                        Console.WriteLine("Enter state");
                                        string currentState = Console.ReadLine();
                                        sample.State = currentState;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 6:
                                        Console.WriteLine("Enter phone number");
                                        string currentPhoneNumber = Console.ReadLine();
                                        sample.PhoneNumber = currentPhoneNumber;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 7:
                                        Console.WriteLine("Enter zip ocde");
                                        long currentZip = Convert.ToInt64(Console.ReadLine());
                                        sample.Zip = currentZip;
                                        input = false;
                                        Console.WriteLine("\n\n\tCONTACT UPDATED SUCESSFULLY....\n\n");
                                        break;
                                    case 8:
                                        Console.WriteLine("Enter Email id");
                                        string currentEmail = Console.ReadLine();
                                        sample.Email = currentEmail;
                                        input = false;
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
                { Console.WriteLine("\nThe person is not found"); }
            }

        }

        public void deleteContact()
        {
            
            char per = '\0';
            bool chk = true;
            if (contactList.Count < 1)
            {
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
                            Console.Write("\nDo You Want To Remove Contact (Y/N) : ");
                            per = Console.ReadKey().KeyChar;
                            if (per == 'Y' || per == 'y')
                            {
                                
                                contactList.Remove(sample);
                                Console.WriteLine("\n\n\tCONTACT REMOVE SUCESSFULLY..!!!");
                            }
                            
                            break;
                        }
                    }
                }
                else
                { Console.WriteLine("\nThe person is not found"); }
            }


        }


        public void SearchByCity()
        {
            int iCnt = 0;
            Console.Write("Enter the City Name: ");
            string CityName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nAll the Contact of: " + CityName);
            foreach (var contact in contactList.FindAll(x => x.City == CityName))
            {
                Console.Write("-----------------[" + ++iCnt + "]----------------\n");
                Console.WriteLine("\nFirst Name   :\t{0}\nLast Name    :\t{1}\nAddress      :\t{2}\nCity         :\t{3}\nState        :\t{4}\nPhone Number :\t{5},\nZip Code     :\t{6}",contact.FirstName,contact.LastName,contact.City,contact.State,contact.State,contact.PhoneNumber,contact.Zip);
                Console.Write("-------------------------------------\n");
            }
        }





        public void run()
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("\n\n**************************************************\n");
                Console.Write("\tWelCome To {0} Address Book       \n",name);
                Console.Write("**************************************************\n");
                Console.WriteLine("\n1 : Add Contact\n2 : Display Contacts\n3 : Edit Contact \n4 : Remove Contact \n\n0 : Exit {0} Address Book\n\n",name);
                Console.Write("**************************************************\n");
                Console.Write("Enter Your Choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("\n------------{ Create Contacts }------------\n");
                        createContact();
                        
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        
                        break;
                    case 2:
                        Console.WriteLine("\n------------{ Display Contacts }------------\n");
                        displayContacts();
                        Console.WriteLine();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        
                        break;
                    case 3:
                        Console.WriteLine("\n------------{ Edit Contacts }------------\n");
                        EditDetails();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        
                        break;
                    case 4:
                        Console.WriteLine("\n------------{ Remove Contacts }------------\n");
                        deleteContact();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        
                        break;

                    case 5:
                        Console.WriteLine("\n------------{ Search by City }------------\n");
                        SearchByCity();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.Write("\nPress ENTER Key to Go Back");
                        Console.ReadKey();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the Proper Option......!!!!");
                        break;
                }


            }
        }

    }
}
            
           
                
