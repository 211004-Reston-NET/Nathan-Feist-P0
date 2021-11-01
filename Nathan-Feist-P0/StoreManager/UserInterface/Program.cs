using System;
using System.Collections.Generic;

namespace UserInterface
{
    class Program
    {
        public bool running { get; set; }
        static void Main(string[] args)
        {
            Program StoreManager = new Program();
            MenuInterface page = new MainMenu();

            StoreManager.running = true;
            while (StoreManager.running)
            {
                Console.Clear();
                page.Menu();
                MenuType currentMenu = page.userInput();


                switch (currentMenu)
                {
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.ProductMenu:
                        page = new ProductMenu();
                        break;
                    case MenuType.LocationServices:
                        page = new LocationServices();
                        break;
                    case MenuType.OrderMenu:
                        page = new OrderMenu();
                        break;
                    case MenuType.UserMenu:
                        page = new UserMenu();
                        break;
                    case MenuType.Exit:
                        page = new Exit();
                        break;
                        
                    default:

                        page = new MainMenu();
                        break;
                }
            }
        }
    }
}