using System;

namespace userInterface
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class UserMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {   
            Console.WriteLine("------Users------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-------- Users Menu Choices--------");
            Console.WriteLine("[1] - Add New User: ");
            Console.WriteLine("[2] - View A List of Users: ");
            Console.WriteLine("[3] - Search For A User: ");
            Console.WriteLine("[x] - Return to The Main Menu: ");
            Console.WriteLine("---------------------------------------");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //This case will add a user to store app
                case "1":
                    return MenuType.AddUsers;
                //This case will show a list of users    
                case "2":
                    return MenuType.ShowUsers;
                //This case will search for a user
                case "3":
                    return MenuType.CurrentUsers;    
                case "x":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ExitMenu;
            }
        }
    }

}