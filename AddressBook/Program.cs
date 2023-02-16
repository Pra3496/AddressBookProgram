namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            AddressBook addressBook = new AddressBook();
             
            while (flag)
            {
                Console.Write("\n\n**************************************************\n");
                Console.Write("*\tWelCome To Address Book Application      *\n");
                Console.Write("**************************************************\n");
                Console.WriteLine("\n1 : Add Contact\n2 : Display Contacts\n3 : Edit Contact \n4 : Remove Contact \n5 : Exit Application\n");
                Console.Write("**************************************************\n");
                Console.Write("Enter Your Choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("\n------------{ Create Contacts }------------\n");
                        addressBook.createContact();
                        Console.WriteLine("\n\nCONTACT ADDED SUCESSFULLY....\n\n");
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n------------{ Display Contacts }------------\n");
                        addressBook.displayContacts();
                        Console.WriteLine();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n------------{ Edit Contacts }------------\n");
                        addressBook.EditDetails();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\n------------{ Remove Contacts }------------\n");
                        addressBook.deleteContact();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("\nThank You For Using Application");
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