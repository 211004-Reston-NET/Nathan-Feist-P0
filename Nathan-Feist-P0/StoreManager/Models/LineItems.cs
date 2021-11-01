using System;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
                { 
                private int  _lineItemId;
                private string _storeItems;
                private string _storeAddress;
                private int _storeQuantity;
                public int LineItemId 
                {
                        get { return _lineItemId; }
                        set { _lineItemId = value; }
                }
                public string StoreItems
                    {
                        get { return _storeItems; }
                        set 
                        {
                            //Main idea - this Regex will find me any number inside of my string
                            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                            {
                                //Will give the user an exception whenever you try to set the city field with a number
                                throw new Exception("Items can only hold letters!");
                            }
                            _storeItems = value;
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
                                throw new Exception("Items can only hold letters!");
                            }
                            _storeAddress = value;
                        }
                    }
                    public int StoreQuantity 
                {
                        get { return _storeQuantity; }
                        set { _storeQuantity = value; }
                }

                    public override string ToString()
                    {
                        string Users = 
                        $@"StoreItems: {StoreItems}
                        StoreAddress: {StoreAddress}
                        Quantity: {StoreQuantity}
                        
                        ";
                        
                        return Users;   
                    }

                }
            }