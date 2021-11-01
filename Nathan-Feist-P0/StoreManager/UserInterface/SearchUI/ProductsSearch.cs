using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentProducts : IMenu
    {
        private IProductsBL _productsBL;
        public CurrentProducts(IProductsBL p_productsBL)
        {
            this._productsBL = p_productsBL;
        }

        public void Menu()
        {
            List<Products> listOfProducts = _productsBL.GetProducts(ShowProducts._findProductsName);

            Console.WriteLine("This is the search result");
            foreach (Products products in listOfProducts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(products);
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
                    return MenuType.ShowProducts;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentProducts;
            }
        }
    }
}