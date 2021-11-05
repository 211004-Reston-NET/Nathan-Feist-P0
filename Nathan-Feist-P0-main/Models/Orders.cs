using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class Orders
    {

        private int _orderId;
        private decimal _totalPrice;
        private string _storeAddress;

        private string _userName;
        private string _productName;
        private decimal _productPrice;
        private int _itemQuantity;

        
        private List<Orders> _orders = new List<Orders>();
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




        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public decimal ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }
        public object StoreAddressId { get; set; }
       


        
            public List<Orders> Order { get { return _orders; } set { _orders = value; } }

        public override string ToString()
        {
            return $"OrderID: {_orderId}\n Name: {UserName}\nAddress: {StoreAddress}\nProduct Name: {ProductName}\nProduct Price: {ProductPrice}\nItem Quantity: {ItemQuantity}\nTotal Price: {TotalPrice}";
        }
    }

}
