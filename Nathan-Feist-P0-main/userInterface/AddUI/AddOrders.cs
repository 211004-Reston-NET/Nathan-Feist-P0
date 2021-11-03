using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
        {
        
    
        private static Orders _orders = new Orders();
        private static Products _product = new Products();
        private static Users _users = new Users();
        private IOrdersBL _ordersBL;
         
        public AddOrders(IOrdersBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
        }
               public void Menu()
        {
            Console.WriteLine("Make A New Order ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Product Name: {_product.ProductName}"); 
            Console.WriteLine($"Price: {_orders.TotalPrice}");
            Console.WriteLine($"Address: {_users.UserAddress}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[1] - Please Enter Product Name: ");
            Console.WriteLine("[2] - It cost:");
            Console.WriteLine("[3] - Please Enter Shipping Address:");
            Console.WriteLine("[4] - Save Order");
            Console.WriteLine("[x] - Return to Users Menu");
            Console.WriteLine("---------------------------------------");
        } 

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                     Console.WriteLine("Please Enter The Product Name:");
                     _product.ProductName = Console.ReadLine();
                     return MenuType.AddOrders;
                case "2":
                     Console.WriteLine("The Product cost:");
                     _orders.TotalPrice = Int32.Parse( Console.ReadLine());
                     return MenuType.AddOrders;
                case "3":
                    Console.WriteLine("Please Enter Your Shipping Address");
                    _users.UserAddress = Console.ReadLine();
                    return MenuType.AddOrders;
                case "4":
                     _ordersBL.AddOrders(_orders);
                     Console.WriteLine("Order Has Been Saved");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                     return MenuType.OrdersMenu;
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
