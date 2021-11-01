using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class UsersRepo : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/.JSON/";
        private string _jsonString;



        public Users AddUsers(Users p_Users)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Users> listOfUsers = GetAllUsers();

            //We added the new restaurant from the parameter 
            listOfUsers.Add(p_Users);

            _jsonString = JsonSerializer.Serialize(listOfUsers, new JsonSerializerOptions { WriteIndented = true });

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath + "Users.JSON", _jsonString);

            //Will return a restaurant object from the parameter
            return p_Users;
        }



        public List<Users> GetAllUsers()
        {

            try
            {
                _jsonString = File.ReadAllText(_filepath + "Users.JSON");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                Users newUsers = new Users();
                List<Users> listOfUsers = new List<Users>();
                listOfUsers.Add(newUsers);

                //Added a file to database folder
                File.WriteAllText(_filepath + "Users.JSON", JsonSerializer.Serialize<List<Users>>(listOfUsers));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath + "Users.JSON");
            }


            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Users>>(_jsonString);
        }

        public List<Review> GetAllReview()
        {
            _jsonString = File.ReadAllText(_filepath + "Review.JSON");

            return JsonSerializer.Deserialize<List<Review>>(_jsonString);

        }
    }
}
