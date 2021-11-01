using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddStoreLocations : IMenu
    {
        private static StoreLocations _storeLocations = new StoreLocations();
        private IStoreLocationsBL _storeLocationsBL;
         
        public AddStoreLocations(IStoreLocationsBL p_storeLocationsBL)
            {
                _storeLocationsBL = p_storeLocationsBL;
            }

        

            public void Menu()
            {
                Console.WriteLine("Welcome To Add A StoreLocations! ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Name: {_storeLocations.StoreName}");
                Console.WriteLine($"Address: {_storeLocations.StoreAddress}");
                Console.WriteLine($"Phone: {_storeLocations.StorePhone}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("[1] - Please Enter Name: ");
                Console.WriteLine("[2] - Please Enter Address: ");
                Console.WriteLine("[3] - Please Enter Phone Number: ");
                Console.WriteLine("[4] - Save A StoreLocations: ");
                Console.WriteLine("[x] - Go Back: ");
            }

            public MenuType YourChoice()
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    
                    case "1":
                        Console.WriteLine("Please Enter Stores Name: ");
                        _storeLocations.StoreName = Console.ReadLine();
                        return MenuType.AddStoreLocations;
                    case "2":
                        Console.WriteLine("Please Enter Stores Address: ");
                        _storeLocations.StoreAddress = Console.ReadLine();
                        return MenuType.AddStoreLocations;
                    case "3":
                        Console.WriteLine("Please Enter Stores Phone Number: ");
                        _storeLocations.StorePhone = Console.ReadLine();
                        return MenuType.AddStoreLocations;
                     case "4":
                        _storeLocationsBL.AddStoreLocations(_storeLocations);
                        Console.WriteLine("StoreLocations Has Been Added");
                        Console.WriteLine("Please Press Enter! ");
                        Console.ReadLine();
                        return MenuType.StoreLocationsMenu;
                     
                    case "x":
                        return MenuType.StoreLocationsMenu;
                    default:
                        Console.WriteLine("Please input a valid response!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.ShowStoreLocations;
                }
            }
        }
    }