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
                Console.WriteLine("\n1 : Add Contact\n2 : Display Contacts\n3 : Edit Contact \n4 : Exit Application\n");
                Console.Write("**************************************************\n");
                Console.Write("Enter Your Choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("------------{ Create Contacts }------------\n");
                        addressBook.createContact();
                        Console.WriteLine("\n\nCONTACT ADDED SUCESSFULLY....\n\n");
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("------------{ Display Contacts }------------\n");
                        addressBook.displayContacts();
                        Console.WriteLine();
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("------------{ Edit Contacts }------------");
                        addressBook.EditDetails();
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Thank You For Using Application");
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