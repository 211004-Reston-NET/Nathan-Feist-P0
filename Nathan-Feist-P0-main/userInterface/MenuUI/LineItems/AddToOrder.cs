using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddToOrder : IMenu
    {
        private LineItemsBL _lineItemBL;
        private OrdersBL _orderBL;
        public AddToOrder (LineItemsBL p_lineItem, OrdersBL p_orderBL)
        {
            _lineItemBL = p_lineItem;
            _orderBL = p_orderBL;
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("=== Adding Item ===");
            Console.WriteLine();
            Console.WriteLine("[1] Select Product");
            Console.WriteLine("[2] Select Quanity");
            Console.WriteLine("[3] Select OrderId");
            Console.WriteLine("-------------------");
            Console.WriteLine("Product ID: "+ Singleton.lineItems.ProductName);      
            Console.WriteLine("Quantity: "+Singleton.lineItems.ItemQuantity);
            Console.WriteLine();
            Console.WriteLine("[4] Add Item");
        }

        public MenuType YourChoice()
       {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                Console.WriteLine("Enter Product ID");
                Singleton.lineItems.LineItemId = Int32.Parse(Console.ReadLine());
                    return MenuType.AddToOrder;

                case "2":
                Console.WriteLine("Enter Quantity");
                Singleton.lineItems.ItemQuantity = Int32.Parse(Console.ReadLine());
                    return MenuType.AddToOrder;

                case "3":
                List<Orders> listOfOrders = _orderBL.GetAllOrders();
                foreach (Orders orders in listOfOrders)
                {
                    Console.WriteLine(orders.OrderId);
                }
                Console.WriteLine("Enter Order ID");
                Singleton.lineItems.LineItemId = Int32.Parse(Console.ReadLine());
                return MenuType.AddToOrder;

                case "4":
                _lineItemBL.AddLineItems(Singleton.lineItems);
                return MenuType.AddToOrder;

                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Invalid Selection!");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}