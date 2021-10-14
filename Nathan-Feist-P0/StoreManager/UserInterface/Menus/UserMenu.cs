using System;

namespace UserInterface
{
    public class UserMenu : MenuInterface
     {
        public void Menu()
        {
            Console.WriteLine("=====Member's Rewards=====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Become a Member");
        }
        public MenuType userInput()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.OrderMenu;

                default:
                    Console.WriteLine("=====YOU HAVE MADE AN INVALID SELECTION=====");
                    Console.WriteLine("Please hit [enter] to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }

        }

    }
}