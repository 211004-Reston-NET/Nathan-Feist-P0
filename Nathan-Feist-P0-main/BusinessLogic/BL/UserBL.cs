using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLogic;
using Models;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class UsersBL :IUsersBL
    {
        private IUsers _users;
        
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_users">It will pass in a Respository object</param>
        public UsersBL(IUsers p_users )
        {
            _users = p_users;
           
        }

        public Users AddUsers(Users p_users)
        {
            if (p_users.UserName == null || p_users.UserAddress == null || p_users.UserEmail == null)
            {
                throw new Exception("You must have a value in all of the properties");
            }

            return _users.AddUsers(p_users);
        }

        public List<Users> GetAllUsers()
        
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Users> listOfUsers = _users.GetAllUsers();
            for (int i = 0; i < listOfUsers.Count; i++)
            {
                listOfUsers[i].UserName = listOfUsers[i].UserName.ToLower(); 
            }

            return listOfUsers;
        }

        

        public List<Review> GetAllReview(Users p_users)
        {
            return _users.GetAllReview(p_users);
        }

        public Users GetUsers(string p_name)
        {
            List<Users> listOfUsers = _users.GetAllUsers();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfUsers.FirstOrDefault(users => users.UserName.ToLower() == p_name.ToLower());
        }

        public Users GetUsersById(int p_Id)
        {
            Users usersFound = _users.GetUsersById(p_Id);

            if (usersFound == null)
            {
                throw new Exception("user not found!");
            }

            return usersFound;
        }

        

        
    }
}
       