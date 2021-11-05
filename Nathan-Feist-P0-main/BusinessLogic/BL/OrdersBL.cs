using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLogic;
using Models;
using DataAccessLogic.Entities;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class OrdersBL : IOrdersBL
    {
        private IOrders _orders;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public OrdersBL(IOrders p_orders)
        {
            _orders = p_orders;
        }
        //     public Users AddUsers(Users p_users)
        // {
        //     if (p_users.UserName == null || p_users.UserAddress == null || p_users.UserEmail == null)
        //     {
        //         throw new Exception("You must have a value in all of the properties");
        //     }

        //     return _users.AddUsers(p_users);
        // }


        public Orders AddOrders(Orders p_orders)
        {
            if (p_orders.UserName == null )
            {
                throw new Exception("Value cannot be Null.");
            }

            return _orders.AddOrders(p_orders);
        }

        public List<Orders> GetAllOrders()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Orders> listOfOrders = _orders.GetAllOrders();
            for (int i = 0; i < listOfOrders.Count; i++)
            {
                listOfOrders[i].StoreAddress = listOfOrders[i].StoreAddress.ToLower();
            }

            return listOfOrders;
        }

        public List<Review> GetAllReview(Orders p_orders)
        {
            return _orders.GetAllReview(p_orders);
        }

        public List<Orders> GetOrders(string p_name)
        {
            List<Orders> listOfOrders = _orders.GetAllOrders();

            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfOrders.Where(orders => orders.StoreAddress.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public Orders GetOrdersById(int p_Id)
        {
            Orders ordersFound = _orders.GetOrdersById(p_Id);

            if (ordersFound == null)
            {
                throw new Exception("orders was not found!");
            }

            return ordersFound;
        }
    }
}


