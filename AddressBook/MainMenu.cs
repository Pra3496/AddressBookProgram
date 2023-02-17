using System;


namespace AddressBook
{

        class MainMenu
        {
            private int selectIndex;
            private string[] option;
            private string prompt;
            




            public MainMenu(string[] opt,string pro)
            {

                option = opt;
                prompt = pro;
                selectIndex = 0;


            }

            private void DisplayOptions()
            {
                Console.WriteLine("\n");
                Console.CursorLeft = 85;
                Console.WriteLine(prompt);

                Console.WriteLine();
                Console.CursorLeft = 91;
                Console.WriteLine("-: OPTIONS :-\n");

                for (int i = 0; i < option.Length; i++)
                {
                    string currentOpt = option[i];
                    string prifix;

                    if (i == selectIndex)
                    {
                        prifix = "*";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        prifix = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.CursorLeft = 85;
                    Console.WriteLine($"{prifix} {currentOpt}");
                    Console.ResetColor();

                }


            }


            public int Run()
            {
                ConsoleKey keyPressed;

                do
                {
                    Console.Clear();

                    DisplayOptions();

                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    keyPressed = keyInfo.Key;

                    if (keyPressed == ConsoleKey.UpArrow)
                    {
                        selectIndex--;
                        if (selectIndex == -1)
                        {
                            selectIndex = option.Length - 1;
                        }
                    }
                    else if (keyPressed == ConsoleKey.DownArrow)
                    {
                        selectIndex++;
                        if (selectIndex == option.Length)
                        {
                            selectIndex = 0;
                        }
                    }


                } while (keyPressed != ConsoleKey.Enter);

                return selectIndex;
            }

            

        


        }

}
