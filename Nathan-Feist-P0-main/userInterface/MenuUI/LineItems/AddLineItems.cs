using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddLineItems : IMenu
    {
        private static LineItems _lineItems = new LineItems();
        private ILineItemsBL _lineItemsBL;
         
        public AddLineItems(ILineItemsBL lineItems)
        {
            _lineItemsBL = lineItems;
        }

       

        public void Menu()
        {
            Console.WriteLine("Welcome To Add A Line Items! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Name: {_lineItems.ProductName}");
            Console.WriteLine($"Address: {_lineItems.StoreAddress}");
            Console.WriteLine($"Store Quantity: {_lineItems.ItemQuantity}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter A  Item Name: ");
            Console.WriteLine("[2] - Please Enter A Store Address: ");
            Console.WriteLine("[3] - Please Enter A Quantity For Item:");
            Console.WriteLine("[4] - Save Line Item: ");
            Console.WriteLine("[5] - Get A List Of Items: ");
            Console.WriteLine("[x] - Return to Line Items Menu: ");
            Console.WriteLine("------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "1":
                    Console.WriteLine("Please Enter Items Name:");
                    _lineItems.ProductName = Console.ReadLine();
                    return MenuType.AddLineItems;
                case "2":
                    Console.WriteLine("Please Enter Store Address:");
                    _lineItems.StoreAddress = Console.ReadLine();
                    return MenuType.AddLineItems;    
                case "3":
                    Console.WriteLine("Please Enter Items Quantity:");
                    _lineItems.ItemQuantity = Int32.Parse( Console.ReadLine());
                    return MenuType.AddLineItems;
                case "4":
                    _lineItemsBL.AddLineItems(_lineItems);
                     Console.WriteLine("Line Item Has Been Added");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                    return MenuType.LineItemsMenu; 
                case "5":
                     Console.WriteLine("Get A List Of Items:");
                     _lineItems.LineItem = new List<LineItems>();
                     return MenuType.ShowLineItems;
                
                case "x":
                    return MenuType.LineItemsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowLineItems;
            }
        }
    }
}
