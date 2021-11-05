using System.Collections.Generic;
using System.Linq;
using DataAccessLogic;
using Models;
using Entity = DataAccessLogic.Entities;
using Model = Models;


public class RepositoryCloud : IUsers, ILineItems, IOrders, IProducts, IStoreLocations, IRepository
{
    private Entity.ShopDatabaseP0Context _context;
    public RepositoryCloud(Entity.ShopDatabaseP0Context p_context)
    {
        _context = p_context;
    }


    public Model.Users AddUsers(Model.Users p_users)
    {
        _context.Users.Add(
            new Entity.User()
            {
                UserName = p_users.UserName,
                UserAddress = p_users.UserAddress,
                UserEmail = p_users.UserEmail,
                UserPhone = p_users.UserPhone
            }
        );
        _context.SaveChanges();

        return p_users;


    }

    public List<Models.Users> GetAllUsers()
    {
        return _context.Users.Select(users =>
            new Model.Users()
            {
                UserName = users.UserName,
                UserAddress = users.UserAddress,
                UserEmail = users.UserEmail,
                UserPhone = users.UserPhone,
                UserId = users.UserId


            }
        ).ToList();
    }
    public Users GetUsersById(int p_id)
    {
        Entity.User usersToFind = _context.Users.Find(p_id);

        return new Model.Users()
        {
            UserId = usersToFind.UserId,
            UserName = usersToFind.UserName,
            UserAddress = usersToFind.UserAddress,
            UserEmail = usersToFind.UserEmail,
            UserPhone = usersToFind.UserPhone,


        };
    }




    public List<Review> GetAllReview(Users p_users)
    {
        throw new System.NotImplementedException();
    }

    public Model.Products AddProducts(Model.Products p_orders)
    {
        _context.Products.Add(
            new Entity.Product()
            {
                ProductName = p_orders.ProductName,
                ProductPrice = p_orders.ProductPrice,
                ProductDescription = p_orders.ProductDescription,
                ProductCategory = p_orders.ProductCategory,
            }
        );
        _context.SaveChanges();

        return p_orders;

    }
    public List<Models.Products> GetAllProducts()
    {
        return _context.Products.Select(products =>
            new Model.Products()
            {
                ProductName = products.ProductName,
                ProductPrice = products.ProductPrice,
                ProductDescription = products.ProductDescription,
                ProductCategory = products.ProductCategory,
                ProductId = products.ProductId,

            }

        ).ToList();
    }

    public List<Models.Products> GetAllProduct()
    {
        return _context.Products.Select(products =>
                new Model.Products()
                {
                    ProductName = products.ProductName,
                    ProductPrice = products.ProductPrice,
                    ProductDescription = products.ProductDescription,
                    ProductCategory = products.ProductCategory,
                    ProductId = products.ProductId


                }
            ).ToList();
    }

    public Products GetProductsById(int p_id)
    {
        Entity.Product productsToFind = _context.Products.Find(p_id);

        return new Model.Products()
        {
            ProductId = productsToFind.ProductId,
            ProductName = productsToFind.ProductName,
            ProductPrice = productsToFind.ProductPrice,
            ProductDescription = productsToFind.ProductDescription,
            ProductCategory = productsToFind.ProductCategory,


        };

    }

    public List<Review> GetAllReview(Products p_storeLocations)
    {
        throw new System.NotImplementedException();
    }
    public Model.LineItems AddLineItems(Model.LineItems p_lineItems)
    {
        _context.LineItems.Add(
                new Entity.LineItem()
                {
                    QuantityNumber = p_lineItems.ItemQuantity,
                }
               );
        _context.SaveChanges();

        return p_lineItems;
    }

    public List<LineItems> GetAllLineItems()
    {
        return _context.LineItems.Select(lineItems =>
                new Model.LineItems()
                {

                    ItemQuantity = (int)lineItems.QuantityNumber,
                    LineItemId = lineItems.LineItemId,


                }
            ).ToList();
    }

    public List<Review> GetAllReview(LineItems p_lineItems)
    {
        throw new System.NotImplementedException();
    }


    public LineItems GetLineItemsById(int p_id)
    {
        Entity.LineItem lineItemsToFind = _context.LineItems.Find(p_id);

        return new Model.LineItems()
        {
            LineItemId = lineItemsToFind.ProductId,
            ItemQuantity = (int)lineItemsToFind.QuantityNumber,

        };
    }

    public Orders AddOrders(Orders p_orders)
    {
        _context.Orders.Add(
                new Entity.Order()
                {

                    OrderId = p_orders.OrderId,
                    TotalPrice = p_orders.TotalPrice,
                    StoreAddress = p_orders.StoreAddress,
                    UserName = p_orders.UserName,
                    ProductName = p_orders.ProductName,
                    ProductPrice = p_orders.ProductPrice,
                    ItemQuantity = p_orders.ItemQuantity,



                }
            );
        _context.SaveChanges();

        return p_orders;
    }
    public List<Orders> GetAllOrders()
    {
        return _context.Orders.Select(orders =>
                new Model.Orders()
                {
                    OrderId = orders.OrderId,
                    TotalPrice = orders.TotalPrice,
                    StoreAddress = orders.StoreAddress,
                    UserName = orders.UserName,
                    ProductName = orders.ProductName,
                    ProductPrice = orders.ProductPrice,
                    ItemQuantity = orders.ItemQuantity,




                }
            ).ToList();
    }

    public List<Review> GetAllReview(Orders p_orders)
    {
        throw new System.NotImplementedException();
    }

    Orders IOrders.GetOrdersById(int p_Id)
    {
        Entity.Order ordersToFind = _context.Orders.Find(p_Id);

        return new Model.Orders()
        {
            OrderId = ordersToFind.OrderId,
            StoreAddress = ordersToFind.StoreAddress,
            TotalPrice = ordersToFind.TotalPrice,

        };
    }

    public StoreLocations AddStoreLocations(StoreLocations p_storeLocations)
    {
        _context.StoreLocations.Add(
                new Entity.StoreLocation()
                {
                    StoreName = p_storeLocations.StoreName,
                    StoreAddress = p_storeLocations.StoreAddress,
                    StorePhone = p_storeLocations.StorePhone,

                }
            );
        _context.SaveChanges();

        return p_storeLocations;
    }

    public List<StoreLocations> GetAllStoreLocations()
    {
        return _context.StoreLocations.Select(storeLocations =>
                new Model.StoreLocations()
                {
                    StoreName = storeLocations.StoreName,
                    StoreAddress = storeLocations.StoreAddress,
                    StorePhone = storeLocations.StorePhone,
                    StoreId = storeLocations.StoreId


                }
            ).ToList();
    }

    public List<Review> GetAllReview(StoreLocations p_storeLocations)
    {
        throw new System.NotImplementedException();
    }

    public StoreLocations GetStoreLocationsById(int p_id)
    {
        Entity.StoreLocation StoreLocationsToFind = _context.StoreLocations.Find(p_id);
        return new Models.StoreLocations() 
        {
            StoreId = StoreLocationsToFind.StoreId,
            StoreAddress = StoreLocationsToFind.StoreAddress,
            StoreName = StoreLocationsToFind.StoreAddress,
            StorePhone = StoreLocationsToFind.StoreAddress,
        };
    }

}
