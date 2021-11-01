using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
        public class StoreLocations
                {
                private int _storeLocationsId;
                private string _storeName;
                private string _storeAddress;
                private List<Orders> _orders = new List<Orders>();
                private List<Products> _products = new List<Products>();
                
                    
                //This is a property that uses the field called _name
                public int StoreLocationsId
                {
                        get { return _storeLocationsId; }
                        set { _storeLocationsId = value; }
                }
                public string StoreName
                {
                get { return _storeName; }
                set 
                {
                    //Main idea - this Regex will find me any number inside of my string
                    if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                    {
                    //Will give the user an exception whenever you try to set the city field with a number
                        throw new Exception("City can only hold letters!");
                    }
                    _storeName = value;
                }
                }   
                public string StoreAddress
                {
                get { return _storeAddress; }
                set 
                {
                    //Main idea - this Regex will find me any number inside of my string
                    if (!Regex.IsMatch(value, @"^[A-Za-z0-9'\.\-\s\,]"))
                    {
                    //Will give the user an exception whenever you try to set the city field with a number
                        throw new Exception("City can only hold letters!");
                    }
                    _storeAddress = value;
                }
                }
            public List<Reviews> Reviews { get; set; }
            public List<Orders> Orders
            { 
            get {return _orders;}
            set {_orders = value;}
            }
        
            public List<Products> Products
            { 
            get {return _products;}
            set {_products = value;}    
            }
                    public override string ToString()
                    {
                        string Users = 
                        $@"Store Name: {StoreName}
                        Store Address: {StoreAddress}
                        Store Orders: {Orders}
                        Store Products : {Products}
                        ";
                        
                        return Users;   




                    }

                }
            }