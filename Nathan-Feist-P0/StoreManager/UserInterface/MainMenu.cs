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
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("What Would You Like To Do? ");
            Console.WriteLine("[1] - Go to Users Menu: ");
            Console.WriteLine("[2] - Go to Line Items Menu: ");
            Console.WriteLine("[3] - Go to Orders Menu: ");
            Console.WriteLine("[4] - Go to Products Menu: ");
            Console.WriteLine("[5] - Go to StoreLocation Menu: ");
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
                     return MenuType.LineItemsMenu; 
                case "3":
                    return MenuType.OrdersMenu;
                case "4":
                    return MenuType.ProductsMenu;   
                case "5":
                    return MenuType.StoreLocationsMenu;       
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