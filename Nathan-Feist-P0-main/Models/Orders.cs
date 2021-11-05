using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class Orders
    {
        private int _orderId;
        
        private string _storeAddress;
        private decimal _totalPrice;
        public int UserId { get; set; }
        private List<LineItems> _lineItems = new List<LineItems>();
        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
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
                    throw new Exception("City can only hold letters and numbers!");
                }
                _storeAddress = value;
            }
        }

        public List<LineItems> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }

        }

        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public object StoreAddressId { get; set; }
        public List<Orders> Order { get; set; }

        public override string ToString()
        {
            string Users =
                    $@"Store Address: {StoreAddress}
                    Total Price: {TotalPrice}
                    List of Line Items: {LineItems}";

            return Users;
        }

    }
}