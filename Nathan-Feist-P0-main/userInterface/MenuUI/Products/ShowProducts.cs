using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowProducts : IMenu
    {
        private IProductsBL _productsBL;
        public static string _findProductsName;
        public ShowProducts(IProductsBL p_productsBL)
        {
            _productsBL = p_productsBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<Products> listOfProducts = _productsBL.GetAllProducts();

            foreach (Products _products in listOfProducts)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(_products);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("[1] - Search for a Product");
            Console.WriteLine("[2] - Order a Product");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.ProductsMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Product you want to find");
                    _findProductsName = Console.ReadLine();
                    return MenuType.CurrentProducts;
                case "2":
                    return MenuType.AddOrders;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowProducts;
            }
        }
    }
}