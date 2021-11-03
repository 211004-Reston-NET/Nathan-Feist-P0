using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class CurrentUsers : IMenu
    {
        private IUsersBL _usersBL;
        private static Users _currentUser = new Users();
        public CurrentUsers(IUsersBL p_usersBL)
        {
            this._usersBL = p_usersBL;
        }

        public void Menu()
        {
            Console.WriteLine("This is the search result");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(_currentUser);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[1] - Search By Name Of User: ");
            Console.WriteLine("[2] - Search By User Id:");
            Console.WriteLine("[x] - Go Back: ");
            Console.WriteLine("---------------------------------------");


        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "x":
                    return MenuType.UserMenu;
                case "1":
                    Console.WriteLine("Enter a User's Name: ");
                    _currentUser.UserName = Console.ReadLine();
                    _currentUser = _usersBL.GetUsers(_currentUser.UserName);
                    return MenuType.CurrentUsers;
                case "2":
                    Console.WriteLine("Enter a User's ID:");
                    _currentUser.UserId = Int32.Parse(Console.ReadLine());
                    _currentUser = _usersBL.GetUsersById(_currentUser.UserId);
                    return MenuType.CurrentUsers;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CurrentUsers;
            }
        }
    }
}