using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentOrders : IMenu
    {
        private IOrdersBL _ordersBL;
        public CurrentOrders(IOrdersBL p_ordersBL)
        {
            this._ordersBL = p_ordersBL;
        }

        public void Menu()
        {
            List<Orders> listOfOrders = _ordersBL.GetOrders(ShowOrders._findOrdersName);

            Console.WriteLine("This is the search result");
            foreach (Orders orders in listOfOrders)
            {
                Console.WriteLine("====================");
                Console.WriteLine(orders);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowOrders;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentOrders;
            }
        }
    }
}