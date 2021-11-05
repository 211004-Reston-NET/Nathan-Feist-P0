using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
     public class ShowOrders : IMenu
    {
        private static Users _users = new Users();
        private static Orders _orders = new Orders();
        private IOrdersBL _ordersBL;
        private IUsersBL _usersBL;
        public static string _findOrdersName;
        
        public ShowOrders(IOrdersBL orders, IUsersBL users)
        {
            _ordersBL = orders;
            _usersBL = users;
        }
        public void Menu()
        {
            Console.WriteLine("List of Orders");
            List<Orders> listOfOrders = _ordersBL.GetAllOrders();

            foreach (Orders orders in listOfOrders)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(orders);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("[1] - Search for a Order");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.OrdersMenu;
                case "1":
                    // Console.WriteLine("Enter the name of the Buyer");
                    // _findOrdersName = Console.ReadLine();
                    // return MenuType.CurrentOrders;
                     Console.WriteLine("Enter a User's Name: ");
                    _users.UserName = Console.ReadLine();
                    _users = _usersBL.GetUsers(_users.UserName);
                    return MenuType.ShowOrders;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowOrders;
            }
        }
    }
}