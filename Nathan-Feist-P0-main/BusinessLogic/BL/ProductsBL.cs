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
        public class ProductsBL : IProductsBL
        {
            private IProducts _products;
            /// <summary>
            /// We are defining the dependencies this class needs to operate
            /// We do it this way because we can easily switch out which implementation details we will be using
            /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
            /// have the implementation
            /// </summary>
            /// <param name="p_repo">It will pass in a Respository object</param>
            public ProductsBL(IProducts p_products)
            {
                _products = p_products;
            }

            public Products AddProducts(Products p_products)
        {
            if (p_products.ProductName == null || p_products.ProductDescription == null || p_products.ProductCategory == null)
            {
                throw new Exception("You must have a value in all of the properties of the restaurant class");
            }

            return _products.AddProducts(p_products);
        }
        

        public List<Products> GetAllProducts()
            {
                //Maybe my business operation needs to capitalize every name of a restaurant
                List<Products> listOfProducts = _products.GetAllProducts();
                for (int i = 0; i < listOfProducts.Count; i++)
                {
                    listOfProducts[i].ProductName = listOfProducts[i].ProductName.ToLower(); 
                }

                return listOfProducts;
            }

        public List<Review> GetAllReview(Products p_products)
        {
           return _products.GetAllReview(p_products);
        }

        public List<Products> GetProducts(string p_name)
            {
                List<Products> listOfProducts = _products.GetAllProducts();
                
                //Select method will give a list of boolean if the condition was true/false
                //Where method will give the actual element itself based on some condition
                //ToList method will convert into List that our method currently needs to return.
                //ToLower will lowercase the string to make it not case sensitive
                return listOfProducts.Where(rest => rest.ProductName.ToLower().Contains(p_name.ToLower())).ToList();
            }

        public Products GetProductsById(int p_Id)
        {
            Products productsFound = _products.GetProductsById(p_Id);

            if (productsFound == null)
            {
                throw new Exception("products was not found!");
            }

            return productsFound;
        }
    }
    }