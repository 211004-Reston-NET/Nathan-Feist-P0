using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class StoreLocationsMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("    Welcome to the StoreLocations Menu!  ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-------- StoreLocations Menu Choices--------");
            Console.WriteLine("[1] - Add New StoreLocations: ");
            Console.WriteLine("[2] - View A List of StoreLocations: ");
            Console.WriteLine("[3] - Search For A StoreLocation: ");
            Console.WriteLine("[x] - Go back to The Main Menu: ");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddStoreLocations;
                case "2":
                    return MenuType.ShowStoreLocations;
                case "3":
                    return MenuType.CurrentStoreLocations;   
                case "x":
                    return MenuType.MainMenu; 
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreLocationsMenu;
            }
        }
    }
}