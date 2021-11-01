using System;

namespace UserInterface
{
    public class MainMenu : MenuInterface
    {
        public void Menu()
        {
            Console.WriteLine("=====Main Menu=====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Location Services");
            Console.WriteLine("[2] View Products");
            Console.WriteLine("[3] Make an Order");
            Console.WriteLine("[4] Sign up for our Rewards Plan");
            
        }

        public MenuType userInput()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.LocationServices;
                case "2":
                    return MenuType.ProductMenu;
                case "3":
                    return MenuType.OrderMenu;
                case "4":
                    return MenuType.UserMenu;
                default:
                    Console.WriteLine("=====YOU HAVE MADE AN INVALID SELECTION=====");
                    Console.WriteLine("Please hit [enter] to continue");
                    
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}