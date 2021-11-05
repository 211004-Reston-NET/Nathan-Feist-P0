using System;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddOrders : IMenu
    {
        private static Orders _order = new Orders();
        private static Users _users = new Users();
        private static Products _products = new Products();
        private static LineItems _lineItems = new LineItems();
        private static StoreLocations _store = new StoreLocations();

        private IOrdersBL _ordersBL;
        private IUsersBL _usersBL;
        private IProductsBL _productsBL;
        private ILineItemsBL _lineItemsBL;
        private IStoreLocationsBL _storeBL;





        public AddOrders(IOrdersBL orders, IUsersBL users, IProductsBL products, ILineItemsBL lineItems, IStoreLocationsBL store)
        {
            _ordersBL = orders;
            _usersBL = users;
            _productsBL = products;
            _lineItemsBL = lineItems;
            _storeBL = store;







        }




        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("==== Order Information ====");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Order ID: {_order.OrderId}");
            Console.WriteLine($"User ID: {_users.UserId}");
            Console.WriteLine($"User Name: {_users.UserName}");
            Console.WriteLine($"Product Name: {_products.ProductName}");
            Console.WriteLine($"Product Price:{_products.ProductPrice}");
            Console.WriteLine($"Stock: {_products.ProductQuantity}");
            Console.WriteLine($"Amount To Purchas: {_lineItems.ItemQuantity}");
            Console.WriteLine($"Store Name: {_store.StoreName}");
            Console.WriteLine($"Address: {_store.StoreAddress}");
            Console.WriteLine($"Total Price: {_order.TotalPrice}");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[1] Select Customer");
            Console.WriteLine("[2] Select Product");
            Console.WriteLine("[3] Select Quantity");
            Console.WriteLine("[4] Select Store");
            Console.WriteLine("---------------------------------------");
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
                    _order.TotalPrice = _lineItems.ItemQuantity * _products.ProductPrice;



                    return MenuType.AddOrders;
                case "4":
                    Console.WriteLine("Select Store Location");
                    _store.StoreId = Int32.Parse(Console.ReadLine());
                    _store = _storeBL.GetStoreLocationsById(_store.StoreId);

                    return MenuType.AddOrders;
                case "5":

                    _order.UserName = _users.UserName;
                    _order.StoreAddress = _store.StoreAddress;
                    _order.ProductName = _products.ProductName;
                    _order.ProductPrice = _products.ProductPrice;
                    _order.ItemQuantity = _lineItems.ItemQuantity;

                    _products.ProductQuantity = _products.ProductQuantity - _order.ItemQuantity;


                    _ordersBL.AddOrders(_order);

                    Console.WriteLine("An Order Has Been Added");
                    Console.WriteLine("Please Press Enter! ");
                    Console.ReadLine();
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