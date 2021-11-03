using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace userInterface
{
    public class ShowUsers : IMenu
    {
        private IUsersBL _usersBL;
        public static string _findUsersName;
        public ShowUsers(IUsersBL p_usersBL)
        {
            _usersBL = p_usersBL;
        }
        public void Menu()
        {
            Console.WriteLine("   List of Users    ");
            Console.WriteLine("---------------------------------");
            List<Users> listOfUsers = _usersBL.GetAllUsers();

            foreach (Users users in listOfUsers)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(users);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("[1] - Search for a User");
            Console.WriteLine("[x] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "x":
                    return MenuType.UserMenu;
                case "1":
                    Console.WriteLine("Enter a name for the User you want to find");
                    _findUsersName = Console.ReadLine();
                    return MenuType.CurrentUsers;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowUsers;
            }
        }
    }
}