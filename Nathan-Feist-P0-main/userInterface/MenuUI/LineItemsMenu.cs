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
            Console.WriteLine("------Line-Item------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Would You Like To... ");
            Console.WriteLine("[1] Add New Line Item: ");
            Console.WriteLine("[2] View All Inventory: ");
            Console.WriteLine("[3] Order an Item For Restock: ");
            Console.WriteLine("[x] Return to The Main Menu");
            Console.WriteLine("---------------------------------------");
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