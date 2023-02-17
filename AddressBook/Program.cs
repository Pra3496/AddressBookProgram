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
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n*************************************************\n*");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("\tWelCome To Address Book Application");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t*\n*************************************************\n");
                Console.WriteLine("\n1 : Add Contact\n2 : Display Contacts\n3 : Edit Contact \n4 : Remove Contact \n5 : Exit Application\n");
                Console.Write("**************************************************\n");
                Console.Write("Enter Your Choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("\n------------{ ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Create Contacts");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" }------------\n");
                        addressBook.createContact();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\n\tCONTACT ADDED SUCESSFULLY....\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("\n------------{ ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Display Contacts");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" }------------\n");
                        addressBook.displayContacts();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("\n------------{ ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Edit Contacts");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" }------------\n");
                        addressBook.EditDetails();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("\n------------{ ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Edit Contacts");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" }------------\n");
                        addressBook.deleteContact();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("\nThank You For Using Application");
                        flag = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the Proper Option......!!!!");
                        break;
                }
                

            }
        }
    }
}