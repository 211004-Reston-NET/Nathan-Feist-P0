using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentStoreLocations : IMenu
    {
        private IStoreLocationsBL _storeLocationsBL;
        private static StoreLocations _currentStoreLocations = new StoreLocations();
        public CurrentStoreLocations(IStoreLocationsBL p_storeLocationsBL)
        {
            this._storeLocationsBL = p_storeLocationsBL;
        }

        public void Menu()
        {
            Console.WriteLine("This is the search result");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(_currentStoreLocations);
            Console.WriteLine("---------------------------------------");
           
            Console.WriteLine("[1] - Search Name Of StoreLocations: "); 
            Console.WriteLine("[x] - Go Back: ");
            Console.WriteLine("---------------------------------------");
        }


        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.StoreLocationsMenu;
                case "1":
                    Console.WriteLine("StoreLocations to Search For: ");
                    _currentStoreLocations.StoreName = Console.ReadLine();
                    _currentStoreLocations = _storeLocationsBL.GetStoreLocations(_currentStoreLocations.StoreName);
                    return MenuType.CurrentStoreLocations;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentStoreLocations;
            }
        }
    }
}