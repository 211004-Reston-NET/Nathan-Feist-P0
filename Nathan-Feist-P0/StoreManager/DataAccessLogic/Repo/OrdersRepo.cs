using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class OrdersRepo : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/.JSON/";
        private string _jsonString;



        public Orders AddOrders(Orders p_orders)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Orders> listOfOrders = GetAllOrders();

            //We added the new restaurant from the parameter 
            listOfOrders.Add(p_orders);

            _jsonString = JsonSerializer.Serialize(listOfOrders, new JsonSerializerOptions { WriteIndented = true });

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath + "Orders.JSON", _jsonString);

            //Will return a restaurant object from the parameter
            return p_orders;
        }


        public List<Orders> GetAllOrders()
        {

            try
            {
                _jsonString = File.ReadAllText(_filepath + "Orders.JSON");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                Orders neworders = new Orders();
                List<Orders> listOfOrders = new List<Orders>();
                listOfOrders.Add(neworders);

                //Added a file to database folder
                File.WriteAllText(_filepath + "Orders.JSON", JsonSerializer.Serialize<List<Orders>>(listOfOrders));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath + "Orders.JSON");
            }


            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Orders>>(_jsonString);
        }

        public List<Review> GetAllReview()
        {
            _jsonString = File.ReadAllText(_filepath + "Review.JSON");

            return JsonSerializer.Deserialize<List<Review>>(_jsonString);
        }
    }
}
