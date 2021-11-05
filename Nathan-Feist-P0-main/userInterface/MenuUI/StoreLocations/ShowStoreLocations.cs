using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
     public class ShowStoreLocations : IMenu
    {
        private IStoreLocationsBL _storeLocationsBL;
        public static string _findStoreLocationsName;
        public ShowStoreLocations(IStoreLocationsBL p_storeLocationsBL)
        {
            _storeLocationsBL = p_storeLocationsBL;
        }
        public void Menu()
        {
            Console.WriteLine("-----List of Our Locations-----");
            Console.WriteLine("--------------------------------");
            List<StoreLocations> listOfStoreLocations = _storeLocationsBL.GetAllStoreLocations();

            foreach (StoreLocations storeLocations in listOfStoreLocations)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(storeLocations);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("[1] - Search for a StoreLocation");
            Console.WriteLine("[2] - Choose Which Store you would like to buy from");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.StoreLocationsMenu;
                case "1":
                    Console.WriteLine("Enter a name for the StoreLocation you want to find");
                    _findStoreLocationsName = Console.ReadLine();
                    return MenuType.CurrentStoreLocations;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreLocations;
            }
        }
    }
}