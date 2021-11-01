using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class AddUsers : IMenu
    {
        private static Users _users = new Users();
        private IUsersBL _usersBL;

        public AddUsers(IUsersBL users)
        {
            _usersBL = users;
        }
        public void Menu()
        {
            Console.WriteLine("Welcome To Add A user! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Name: {_users.UserName}");
            Console.WriteLine($"Address: {_users.UserAddress}");
            Console.WriteLine($"Phone: {_users.UserPhone}");
            Console.WriteLine($"Email: {_users.UserEmail}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] - Please Enter Name: ");
            Console.WriteLine("[2] - Please Enter Address:");
            Console.WriteLine("[3] - Please Enter Phone Number:");
            Console.WriteLine("[4] - Please Enter Email:");
            Console.WriteLine("[5] - Save user");
            Console.WriteLine("[6] - Show A List of Order Items");
            Console.WriteLine("[x] - Return to users Menu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please Enter users Name:");
                    _users.UserName = Console.ReadLine();
                    return MenuType.AddUsers;
                case "2":
                    Console.WriteLine("Please Enter users Address:");
                    _users.UserAddress = Console.ReadLine();
                    return MenuType.AddUsers;
                case "3":
                    Console.WriteLine("Please Enter Users Phone Number: ");
                    _users.UserPhone = Console.ReadLine();
                    return MenuType.AddUsers;
                case "4":
                    Console.WriteLine("Please Enter Users Email:");
                    _users.UserEmail = Console.ReadLine();
                    return MenuType.AddUsers;
                case "5":
                    _usersBL.AddUsers(_users);
                    Console.WriteLine("User Has Been Added");
                    Console.WriteLine("Please Press Enter! ");
                    Console.ReadLine();
                    return MenuType.UserMenu;
                case "6":
                    Console.WriteLine("Get A List Of Users Items:");
                    _users.Orders = new List<Orders>();
                    return MenuType.ShowOrders;

                case "x":
                    return MenuType.UserMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowUsers;
            }
        }
    }
}
