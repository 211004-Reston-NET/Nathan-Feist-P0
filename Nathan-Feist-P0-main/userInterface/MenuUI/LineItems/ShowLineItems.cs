using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
     public class ShowLineItems : IMenu
    {
        private ILineItemsBL _lineItemsBL;
        public static string _findLineItemsName;
        public ShowLineItems(ILineItemsBL p_lineItemsBL)
        {
            _lineItemsBL = p_lineItemsBL;
        }
        public void Menu()
        {
            Console.WriteLine($"-----List of Line Items----- from {Singleton.locations}");
            Console.WriteLine("------------------------------");
            List<LineItems> listOfLineItems = _lineItemsBL.GetLineItems(Singleton.orders.StoreAddressId);

            foreach (LineItems lineItems in listOfLineItems)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(lineItems);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("[1] - Search for a Line Item");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.LineItemsMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Line Item you want to find");
                    _findLineItemsName = Console.ReadLine();
                    return MenuType.CurrentLineItems;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowLineItems;
            }
        }
    }
}