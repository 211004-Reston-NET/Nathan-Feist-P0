using System;

namespace UserInterface
{
    public enum MenuType
    {
        MainMenu,
        ProductMenu,
        UserMenu,
        LocationServices,
        OrderMenu,
        Exit,
    
    }
    public interface MenuInterface
    {
        void Menu();
        MenuType userInput();
    }
}