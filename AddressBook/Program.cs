using AddressBook;

namespace aBookdist 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AddressBookDirectory aBookdist = new AddressBookDirectory();
            bool flag = true;

            while (flag)
            {
                Console.Write("\n\n**************************************************\n");
                Console.Write("*\tWelCome To Dictionary Application        *\n");
                Console.Write("**************************************************\n");
                Console.WriteLine("\n1 : Add Address Book \n2 : Display Address Book\n3 : Rename Address Book \n4 : Remove Address Book \n5 : Select Address Book \n\nEnter 0 to Exit Application\n\n");
                Console.Write("**************************************************\n");
                Console.Write("Enter Your Choice : ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("\n------------{ Create Address Book }------------\n");
                        aBookdist.createAddressBook();

                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n------------{ Display Address Book }------------\n");
                        aBookdist.displayDirectory();
                        Console.WriteLine();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n------------{ Rename Address Book }------------\n");
                        aBookdist.renameAddressBook();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\n------------{ Remove Address Book }------------\n");
                        aBookdist.deleteAddressBook();
                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("\n------------{ Select Address Book }------------\n");
                        aBookdist.selectAddressBookForOperation();
                        Console.Clear();
                        break;
                    case 0:
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