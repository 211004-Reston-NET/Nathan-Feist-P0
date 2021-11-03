using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("What Would You Like To Do? ");
            Console.WriteLine("[1] - User Menu: ");
            Console.WriteLine("[2] - Order Products: ");
            Console.WriteLine("[3] - View Products: ");
            Console.WriteLine("[4] - Find a Location Near You: ");
            Console.WriteLine("[5] - View Line Items: ");
            Console.WriteLine("[x] - Exit: ");
            Console.WriteLine("--------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.UserMenu;
                case "2":
                    return MenuType.OrdersMenu;
                case "3":
                    return MenuType.ProductsMenu;
                case "4":
                    return MenuType.StoreLocationsMenu;
                case "5":
                    return MenuType.LineItemsMenu;
                case "x":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}