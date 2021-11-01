using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class LineItemsMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("------Welcome to Line Items Menu------");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("What would you like to do next? ");
            Console.WriteLine("[1] Add New Line Item: ");
            Console.WriteLine("[2] Show All Line Items For Store: ");
            Console.WriteLine("[3] Add Items To A Store Order: ");
            Console.WriteLine("[x] Go back to The Main Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddLineItems;
                case "2":
                    return MenuType.ShowLineItems;
                //If i want to add more cases later
                case "3":
                    return MenuType.AddOrders;
                //case "4":
                  //  return MenuType.ProductsMenu;      
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