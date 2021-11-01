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
        public class StoreLocationsBL: IStoreLocationsBL
        {
            
            private IStoreLocations _storeLocations;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public StoreLocationsBL(IStoreLocations p_storeLocations)
            {
                _storeLocations = p_storeLocations;
            }

            public StoreLocations AddStoreLocations(StoreLocations p_storeLocations)
        {
            if (p_storeLocations.StoreName == null || p_storeLocations.StoreAddress == null )
            {
                throw new Exception("You must have a value in all of the properties to find the store's location.");
            }

            return _storeLocations.AddStoreLocations(p_storeLocations);
        }

        public StoreLocations GetStoreLocations(string p_name)
        {
            List<StoreLocations> listOfStoreLocations = _storeLocations.GetAllStoreLocations();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfStoreLocations.FirstOrDefault(storeLocations => storeLocations.StoreName.ToLower() == p_name.ToLower());
        }


                public List<StoreLocations> GetAllStoreLocations()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<StoreLocations> listOfStoreLocations = _storeLocations.GetAllStoreLocations();
                for (int i = 0; i < listOfStoreLocations.Count; i++)
                {
                    listOfStoreLocations[i].StoreName = listOfStoreLocations[i].StoreName.ToLower(); 
                }

                return listOfStoreLocations;
            }

        public StoreLocations GetStoreLocationsById(int p_Id)
        {
            StoreLocations storeLocationsFound = _storeLocations.GetStoreLocationsById(p_Id);

            if (storeLocationsFound == null)
            {
                throw new Exception("Store Location was not found!");
            }

            return storeLocationsFound;
        }

        public List<Review> GetAllReview(StoreLocations p_storeLocations)
        {
           return _storeLocations.GetAllReview(p_storeLocations);
        }
    }
    }