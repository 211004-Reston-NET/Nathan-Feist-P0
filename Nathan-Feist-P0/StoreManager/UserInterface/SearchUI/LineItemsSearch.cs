using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentLineItems : IMenu
    {
        private ILineItemsBL _lineItemsBL;
        private static LineItems _currentLineItems = new LineItems();
        public CurrentLineItems(ILineItemsBL p_lineItemsBL)
        {
            this._lineItemsBL = p_lineItemsBL;
        }

        public void Menu()
        {
           

            Console.WriteLine("This is the search result");
            Console.WriteLine("====================");
            Console.WriteLine(_currentLineItems);
            Console.WriteLine("====================");
            Console.WriteLine("[0] - Go Back");
            Console.WriteLine("[1] - Search Name Of LineItem: ");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowLineItems;
                case "1":
                    Console.WriteLine("User to Search For: ");
                    _currentLineItems.ProductName = Console.ReadLine();
                    _currentLineItems = _lineItemsBL.GetLineItems(_currentLineItems.ProductName); 
                    return MenuType.CurrentUsers;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentLineItems;
            }
        }
    }
}