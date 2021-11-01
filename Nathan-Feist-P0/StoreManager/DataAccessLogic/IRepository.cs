using System.Collections.Generic;
using Models;




namespace DataAccessLogic
{
    public interface IRepository
    {

    }

    public interface IOrders
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_orders">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Orders AddOrders(Orders p_orders);


        /// <summary>
        /// This will return a list of orders stored in the database
        /// </summary>
        /// <returns>It will return a list of orderss</returns>

        List<Orders> GetAllOrders();
        List<Review> GetAllReview(Orders p_orders);
        Orders GetOrdersById(int p_Id);
    }
    public interface IUsers
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_users">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Users AddUsers(Users p_users);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Users> GetAllUsers();
        List<Review> GetAllReview(Users p_users);
        Users GetUsersById(int p_id);

    }
    public interface IProducts
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Products AddProducts(Products p_products);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Products> GetAllProducts();
        List<Review> GetAllReview(Products p_products);
        Products GetProductsById(int p_id);

    }
    public interface ILineItems
    {
        Users AddUsers(Users p_users);

        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_lineItems">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        LineItems AddLineItems(LineItems p_lineItems);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<LineItems> GetAllLineItems();
        List<Review> GetAllReview(LineItems p_lineItems);
        LineItems GetLineItemsById(int p_id);

    }
    public interface IStoreLocations
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_lineItems">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        StoreLocations AddStoreLocations(StoreLocations p_storeLocations);


        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<StoreLocations> GetAllStoreLocations();
        List<Review> GetAllReview(StoreLocations p_storeLocations);
        StoreLocations GetStoreLocationsById(int p_id);
    }

}
