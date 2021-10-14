using System;

namespace UserInterface
{
    public class ExitMenu : MenuInterface
    {
        public void Menu() { }
        public MenuType userInput()
        {
            Console.WriteLine("Do you really want to exit this program?");
            Console.WriteLine("[Y] or [N]");
            string userInput = Console.ReadLine().ToUpper();
            switch (userInput)
            {
                case "Y":
                    Console.WriteLine("Fine! I didn't want your money anyway!");
                    Environment.Exit(0);
                    return MenuType.ExitMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ExitMenu;
            }

        }
    }
}