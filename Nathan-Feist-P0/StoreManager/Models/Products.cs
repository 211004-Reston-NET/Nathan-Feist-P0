using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Products
        {
            private int _productId;
            private string _productName;
            private string _storeAddress;
            private decimal _productPrice;
            private string _productDescription;
            private string _productCategory;
            
            //This is a property that uses the field called _name
            public int ProductId 
                {
                        get { return _productId; }
                        set { _productId = value; }
                }
            public string ProductName
            {
                get { return _productName; }
                set 
                {
                    //Main idea - this Regex will find me any number inside of my string
                    if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                    {
                        //Will give the user an exception whenever you try to set the city field with a number
                        throw new Exception("Customer Name can only hold letters!");
                    }
                    _productName = value;
                }
            }
            public string StoreAddress
            
                {
                        get { return _storeAddress; }
                        set { _storeAddress = value; }
                }
            public string ProductDescription
            {
                get { return _productDescription; }
                set 
                {
                    //Main idea - this Regex will find me any number inside of my string
                    if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                    {
                        //Will give the user an exception whenever you try to set the city field with a number
                        throw new Exception("Customer Name can only hold letters!");
                    }
                    _productDescription = value;
                }
            }
            public string ProductCategory
            {
                get { return _productCategory; }
                set 
                {
                    //Main idea - this Regex will find me any number inside of my string
                    if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                    {
                        //Will give the user an exception whenever you try to set the city field with a number
                        throw new Exception("Customer Name can only hold letters!");
                    }
                    _productCategory = value;
                }
            }
              public decimal ProductPrice
                {
                        get { return _productPrice; }
                        set { _productPrice = value; }
                }

            public override string ToString()
            {
                string Customers = 
                $@"Product Name: {ProductName}
                Store Address: {StoreAddress}
                Product Description: {ProductDescription}
                Product Category : {ProductCategory}
                ";
                
                return Customers;   

            }
            
            
        }
    }

