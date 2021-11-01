using System;

namespace UserInterface
{
    public class Exit : MenuInterface
    {
        public void Menu (){}
        public MenuType userInput()
        {
            Console.WriteLine("Do you really want to exit this program?");
            Console.WriteLine("[1] Yes or [2] No");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Fine! I didn't want your money anyway!");
                    Environment.Exit(0);
                    return MenuType.Exit;
                
                case "2":
                    return MenuType.MainMenu;

                default:
                    Console.WriteLine("Please, input a valid response!");
                    Console.WriteLine("Press [enter] to get the heck out of here.");
                    Console.ReadLine();
                    return MenuType.Exit;
            }

        }
    }
}