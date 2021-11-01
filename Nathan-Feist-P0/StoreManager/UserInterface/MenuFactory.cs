
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BusinessLogic;
using DataAccessLogic;



namespace userInterface
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("AppSetting.JSON") 
                .Build(); 

            DbContextOptions<Database> options = (DbContextOptions<Database>)new DbContextOptionsBuilder<Database>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.UserMenu:
                    return new UserMenu();
                case MenuType.ShowUsers:
                    return new ShowUsers(new UsersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.AddUsers:
                    return new AddUsers(new UsersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.CurrentUsers:
                    return new CurrentUsers(new UsersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.LineItemsMenu:
                    return new LineItemsMenu();
                case MenuType.ShowLineItems:
                    return new ShowLineItems(new LineItemsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.AddLineItems:
                    return new AddLineItems(new LineItemsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.CurrentLineItems:
                    return new CurrentLineItems(new LineItemsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.OrdersMenu:
                    return new OrdersMenu();
                case MenuType.ShowOrders:
                    return new ShowOrders(new OrdersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.AddOrders:
                    return new AddOrders(new OrdersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.CurrentOrders:
                    return new CurrentOrders(new OrdersBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.ProductsMenu:
                    return new ProductsMenu();
                case MenuType.ShowProducts:
                    return new ShowProducts(new ProductsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.AddProducts:
                    return new AddProducts(new ProductsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.CurrentProducts:
                    return new CurrentProducts(new ProductsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.StoreLocationsMenu:
                    return new StoreLocationsMenu();
                case MenuType.ShowStoreLocations:
                    return new ShowStoreLocations(new StoreLocationsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.AddStoreLocations:
                    return new AddStoreLocations(new StoreLocationsBL(new RepositoryCloud(new DatabaseContext(options))));
                case MenuType.CurrentStoreLocations:
                    return new CurrentStoreLocations(new StoreLocationsBL(new RepositoryCloud(new DatabaseContext(options))));

                default:
                    return null;
            }


        }
    }

   
}