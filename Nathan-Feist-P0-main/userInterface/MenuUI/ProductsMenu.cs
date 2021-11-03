using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class ProductsMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("------Products------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("What would you like to do next? ");
            Console.WriteLine("[1] Add A New Product: ");
            Console.WriteLine("[2] Show All Products For Store: ");
            Console.WriteLine("[3] Search For A Product At Store: ");
            Console.WriteLine("[x] Return to The Main Menu");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddOrders;
                case "2":
                    return MenuType.ShowOrders;
                case "3":
                    return MenuType.AddOrders;
                case "x":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ExitMenu;
            }
        }
    }
}