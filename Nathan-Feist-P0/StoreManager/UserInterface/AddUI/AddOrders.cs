using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
        {
        
    
        private static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;
         
        public AddOrders(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
        }
               public void Menu()
        {
            Console.WriteLine("Welcome To Add A Order! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Address: {_orders.StoreAddress}");
            Console.WriteLine($"Phone: {_orders.TotalPrice}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter Name: ");
            Console.WriteLine("[2] - Please Enter Address:");
            Console.WriteLine("[3] - Please Enter Phone Number:");
            Console.WriteLine("[4] - Please Enter Email:");
            Console.WriteLine("[5] - Save Customer");
            Console.WriteLine("[6] - Show A List of Order Items");
            Console.WriteLine("[x] - Return to Customers Menu");
        } 

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                     Console.WriteLine("Please Enter Customers Name:");
                     _orders.StoreAddress = Console.ReadLine();
                     return MenuType.AddOrders;
                case "2":
                     Console.WriteLine("Please Enter Customers Address:");
                     _orders.TotalPrice = Int32.Parse( Console.ReadLine());
                     return MenuType.AddOrders;
                
                case "5":
                     _ordersBL.AddOrders(_orders);
                     Console.WriteLine("Customer Has Been Added");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                     return MenuType.OrdersMenu;
                case "6":
                     Console.WriteLine("Get A List Of Customers Items:");
                     _orders.Order = new List<Orders>();
                     return MenuType.ShowOrders;
                   
                case "x":
                     return MenuType.OrdersMenu;
                default:
                     Console.WriteLine("Please input a valid response!");
                     Console.WriteLine("Press Enter to continue");
                     Console.ReadLine();
                     return MenuType.ShowOrders;
            }
        }
    }
}
