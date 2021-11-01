using System;

namespace UserInterface
{
    public class OrderMenu : MenuInterface
    {
        public void Menu()
        {
            Console.WriteLine("=====Order Menu=====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Order an Item");
            Console.WriteLine("====================");
        }
        public MenuType userInput()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.OrderMenu;

                default:
                    Console.WriteLine("=====YOU HAVE MADE AN INVALID SELECTION=====");
                    Console.WriteLine("Please hit [enter] to continue");
                    
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }

        }

    }
}