using System;

namespace UserInterface
{
    public class ProductMenu : MenuInterface
    { 
        public void Menu()
        {
            Console.WriteLine("=====Product Menu=====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Order a Product");
            Console.WriteLine("[2] List of Products");
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
                case "2":
                    return MenuType.ProductMenu;

                default:
                    Console.WriteLine("=====YOU HAVE MADE AN INVALID SELECTION=====");
                    Console.WriteLine("Please hit [enter] to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }

        }

    }
}