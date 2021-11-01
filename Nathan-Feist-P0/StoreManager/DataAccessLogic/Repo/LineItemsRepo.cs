using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;




namespace DataAccessLogic
{
    public class LineItemsRepo : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../DataAccessLogic/.JSON/";
        private string _jsonString;



        public LineItems AddLineItems(LineItems p_lineItems)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<LineItems> listOfLineItems = GetAllLineItems();

            //We added the new restaurant from the parameter 
            listOfLineItems.Add(p_lineItems);

            _jsonString = JsonSerializer.Serialize(listOfLineItems, new JsonSerializerOptions { WriteIndented = true });

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath + "LineItems.JSON", _jsonString);

            //Will return a restaurant object from the parameter
            return p_lineItems;
        }


        public List<LineItems> GetAllLineItems()
        {

            try
            {
                _jsonString = File.ReadAllText(_filepath + "LineItems.JSON");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                LineItems newlineItems = new LineItems();
                List<LineItems> listOfLineItems = new List<LineItems>();
                listOfLineItems.Add(newlineItems);

                //Added a file to database folder
                File.WriteAllText(_filepath + "LineItems.JSON", JsonSerializer.Serialize<List<LineItems>>(listOfLineItems));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath + "LineItems.JSON");
            }


            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<LineItems>>(_jsonString);
        }

        public List<Review> GetAllReview()
        {
            _jsonString = File.ReadAllText(_filepath + "Review.JSON");

            return JsonSerializer.Deserialize<List<Review>>(_jsonString);
        }
    }
}
