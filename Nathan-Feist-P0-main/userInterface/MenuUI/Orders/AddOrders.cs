using System;
using System.Collections.Generic;
using BusinessLogic;
using DataAccessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
    {
        private OrdersBL _ordersBL;
        private UsersBL _usersBL;
        private ProductsBL _productsBL;
        private LineItemsBL _lineItemsBL;
      
        private static Orders _orders = new Orders();
        private static Users _users = new Users();
        private static Products _products = new Products();
        private static LineItems _lineItems = new LineItems();
       


        public AddOrders(OrdersBL orders, UsersBL users, ProductsBL products, LineItemsBL lineItems)
        {
            _ordersBL = orders;
            _usersBL = users;
            _productsBL = products;
            _lineItemsBL = lineItems;
        }

        

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("==== Order Information ====");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Order ID:{_orders.OrderId}");
           
            Console.WriteLine($"User ID: {_users.UserId}");
            Console.WriteLine($"User Name: {_users.UserName}");
            Console.WriteLine($"Product Id: {_products.ProductId}");
            Console.WriteLine($"Product Name: {_products.ProductName}");
            Console.WriteLine($"Product Price:{_products.ProductPrice}");
            Console.WriteLine($"Quantity: {_lineItems.ItemQuantity}");
            Console.WriteLine($"Total Price: {_orders.TotalPrice}");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[1] Select Customer");
            
            Console.WriteLine("[2] Select Product");
            Console.WriteLine("[3] Select Quantity");
            Console.WriteLine("[4] Select Store");
            Console.WriteLine("---------------------------------------");
             _orders.OrderId++;
            Console.WriteLine("[5] Save Order");
            Console.WriteLine("[x] Go Back");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.MainMenu;

                case "1":
                    Console.WriteLine("Enter Customer ID");
                    _users.UserId = Int32.Parse(Console.ReadLine());
                    _users = _usersBL.GetUsersById(_users.UserId);

                    
                    return MenuType.AddOrders;

                case "2":
                    Console.WriteLine("Enter Product ID");
                    _products.ProductId = Int32.Parse(Console.ReadLine());
                    _products = _productsBL.GetProductsById(_products.ProductId);
          
                    return MenuType.AddOrders;
                case "3":
                    Console.WriteLine("Enter The Amount You Wish To Purchase");
                    _lineItems.ItemQuantity = Int32.Parse(Console.ReadLine());

                    _orders.TotalPrice = _lineItems.ItemQuantity * _products.ProductPrice;

                    return MenuType.AddOrders;
                case "4":

                    return MenuType.AddOrders;
                case "5":
                     _ordersBL.AddOrders(_orders);
                    Console.WriteLine("An Order Has Been Added");
                    Console.WriteLine("Please Press Enter! ");
                    Console.ReadLine();
                    return MenuType.AddOrders;
                default:
                    Console.WriteLine("Invalid Selection!");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    return MenuType.AddOrders;
            }
        }
    }
}