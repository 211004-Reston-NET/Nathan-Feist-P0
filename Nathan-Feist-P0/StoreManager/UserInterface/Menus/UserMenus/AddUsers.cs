using System;

namespace UserInterface
{
    public class AddUsers : MenuInterface
    {
        public void Menu()
        {
            Console.WriteLine("=====Add A New User=====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Add User");
            
        }
        public MenuType userInput()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                     try
                    {
                        Console.WriteLine("Enter the User Name");
                        newModel.CustName = Console.ReadLine();
                        return MenuType.AddUser;
                    }
                    catch (Exception e)
                    {
                        exceptionMessage = e.Message;
                        return MenuType.AddUser;
                    }

                default:
                    Console.WriteLine("=====YOU HAVE MADE AN INVALID SELECTION=====");
                    Console.WriteLine("Please hit [enter] to continue");
                    
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }

        }

    }
}