using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace BusinessLogic
    {
        /// <summary>
        /// Handles all the business logic for the our restuarant application
        /// They are in charge of further processing/sanitizing/furthur validation of data
        /// Any Logic
        /// </summary>
        public class LineItemsBL: ILineItemsBL
        {
            
            private ILineItems _lineItems;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public LineItemsBL(ILineItems p_lineItems)
            {
                _lineItems = p_lineItems;
            }

        public LineItems AddLineItems(LineItems p_lineItems)
        {
            if (p_lineItems.ProductName == null || p_lineItems.StoreAddress== null )
            {
                throw new Exception("You must have a value in all of the properties of the restaurant class");
            }

            return _lineItems.AddLineItems(p_lineItems);
        }

        public List<LineItems> GetAllLineItems()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<LineItems> listOfLineItems = _lineItems.GetAllLineItems();
                for (int i = 0; i < listOfLineItems.Count; i++)
                {
                    listOfLineItems[i].ProductName = listOfLineItems[i].ProductName.ToLower(); 
                }

                return listOfLineItems;
            }

        public List<Review> GetAllReview(LineItems p_lineItems)
        {
            return _lineItems.GetAllReview(p_lineItems);
        }

       

        public LineItems GetLineItems(string p_name)
            {
                List<LineItems> listOfLineItems = _lineItems.GetAllLineItems();
                
                //Select method will give a list of boolean if the condition was true/false
                //Where method will give the actual element itself based on some condition
                //ToList method will convert into List that our method currently needs to return.
                //ToLower will lowercase the string to make it not case sensitive
                return listOfLineItems.FirstOrDefault(lineItems => lineItems.ProductName.ToLower() == p_name.ToLower());
            }

        public List<LineItems> GetLineItems(object storeFrontId)
        {
            throw new NotImplementedException();
        }

        public LineItems GetLineItemsById(int p_Id)
        {
           LineItems lineItemsFound = _lineItems.GetLineItemsById(p_Id);

            if (lineItemsFound == null)
            {
                throw new Exception("Restaurant was not found!");
            }

            return lineItemsFound;
        }
    }
    }