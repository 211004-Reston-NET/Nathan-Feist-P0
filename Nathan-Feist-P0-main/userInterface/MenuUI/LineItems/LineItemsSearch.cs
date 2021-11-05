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
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(_currentLineItems);
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("[1] - Search For Item By Name ");
            Console.WriteLine("[2] - Search For Item By ID");
            Console.WriteLine("[x] - Go Back");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.ShowLineItems;
                case "1":
                    Console.WriteLine("LineItem to Search For: ");
                    _currentLineItems.ProductName = Console.ReadLine();
                    _currentLineItems = _lineItemsBL.GetLineItems(_currentLineItems.ProductName); 
                    return MenuType.CurrentLineItems;
                case "2":
                    Console.WriteLine("Enter an Item ID:");
                    _currentLineItems.LineItemId = Int32.Parse(Console.ReadLine());
                    _currentLineItems = _lineItemsBL.GetLineItemsById(_currentLineItems.LineItemId);
                    return MenuType.CurrentLineItems;

                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentLineItems;
            }
        }
    }
}