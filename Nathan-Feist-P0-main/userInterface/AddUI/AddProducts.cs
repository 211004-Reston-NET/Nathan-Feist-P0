using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddProducts : IMenu
    {
        private static Products _products = new Products();
        private IProductsBL _productsBL;
         
        public AddProducts(IProductsBL p_productsBL)
        {
            _productsBL = p_productsBL;
        }
             public void Menu()
        {
            Console.WriteLine("Welcome To Add A Product! ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Product Name: {_products.ProductName}");
            Console.WriteLine($"Product Price: {_products.ProductPrice}");
            Console.WriteLine($"Product Description: {_products.ProductDescription}");
            Console.WriteLine($"Product Category: {_products.ProductCategory}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[1] - Please Enter A  Product Name: ");
            Console.WriteLine("[2] - Please Enter A Product Price:");
            Console.WriteLine("[3] - Please Enter A Product Description:");
            Console.WriteLine("[4] = Please Enter A Product Category:");
            Console.WriteLine("[5] - Save A Product");
            Console.WriteLine("[x] - Return to Products Menu");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                
                case "1":
                    Console.WriteLine("Please Enter Product Name:");
                    _products.ProductName = Console.ReadLine();
                    return MenuType.AddProducts;
                case "2":
                    Console.WriteLine("Please Enter Product Price:");
                    _products.ProductPrice = Decimal.Parse( Console.ReadLine());
                    return MenuType.AddProducts;
                case "3":
                    Console.WriteLine("Please Enter Product Description: ");
                    _products.ProductDescription = Console.ReadLine();
                    return MenuType.AddProducts;
                case "4":
                    Console.WriteLine("Please Enter Product Category:");
                    _products.ProductCategory = Console.ReadLine();
                    return MenuType.AddProducts;
                case "5":
                     _productsBL.AddProducts(_products);
                     Console.WriteLine("Product Has Been Added");
                     Console.WriteLine("Please Press Enter! ");
                     Console.ReadLine();
                    return MenuType.ProductsMenu;
                
                case "x":
                    return MenuType.ProductsMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowProducts;
            }
        }
    }
}