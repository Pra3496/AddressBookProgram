namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prompt = @"
                                                               ========================================================================
                                                               *       ___      _     _                    ______             _       *
                                                               *      / _ \    | |   | |                   | ___ \           | |      *
                                                               *     / /_\ \ __| | __| |_ __ ___  ___ ___  | |_/ / ___   ___ | | __   *
                                                               *     |  _  |/ _` |/ _` | '__/ _ \/ __/ __| | ___ \/ _ \ / _ \| |/ /   *
                                                               *     | | | | (_| | (_| | | |  __/\__ \__ \ | |_/ / (_) | (_) |   <    *
                                                               *     \_| |_/\__,_|\__,_|_|  \___||___/___/ \____/ \___/ \___/|_|\_\   *
                                                               *                                                                      *
                                                               ========================================================================
                                                                                                                            ";
            bool flag = true;

            AddressBook addressBook = new AddressBook();

            string[] options = {"|      ADD CONTACT   |", "|  DISPLAY CONTACTS  |", "|     EDIT CONTACT   |","|   REMOVE CONTACT   |", "|       EXIT         |" };
             
            while (flag)
            {
                MainMenu menu = new MainMenu(options,prompt);

                int opt = menu.Run();


                switch (opt)
                {
                    case 0:
                        Console.WriteLine("\n\n");
                        Console.CursorLeft = 77;
                        Console.WriteLine("------------{ Create Contacts }------------\n");
                        addressBook.createContact();
                        Console.CursorLeft = 77;
                        Console.WriteLine("\n");
                        Console.CursorLeft = 77;
                        Console.WriteLine("\tCONTACT ADDED SUCESSFULLY....\n\n");
                        Console.CursorLeft = 77;
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("\n\n");
                        Console.CursorLeft = 77;
                        Console.WriteLine("------------{ Display Contacts }------------\n");
                        addressBook.displayContacts();
                        Console.WriteLine("\n");
                        Console.CursorLeft = 77;
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n\n");
                        Console.CursorLeft = 77;
                        Console.WriteLine("------------{ Edit Contacts }------------\n");
                        addressBook.EditDetails();
                        Console.WriteLine("\n");
                        Console.CursorLeft = 87;
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n\n");
                        Console.CursorLeft = 77;
                        Console.WriteLine("------------{ Remove Contacts }------------\n");
                        addressBook.deleteContact();
                        Console.WriteLine("\n");
                        Console.CursorLeft = 77;
                        Console.Write("Press any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.CursorLeft = 78;
                        Console.WriteLine("Thank You For Using Application");
                        Console.CursorLeft = 74;
                        Console.WriteLine("------------------*-----------------");
                        Console.CursorLeft = 81;
                        Console.WriteLine("Designed and Developed By");
                        Console.CursorLeft = 85;
                        Console.WriteLine("Pranav Waghmare");
                        Console.WriteLine("\n\n");
                        flag = false;
                        break;
                    default:
                        Console.CursorLeft = 77;
                        Console.WriteLine("Enter the Proper Option......!!!!");
                        break;
                }
                

            }
        }
    }
}