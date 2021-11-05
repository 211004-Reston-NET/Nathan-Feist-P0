using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
    {

        private int _lineItemId;
        private string _productName;
        private int _pId;
        private string _storeAddress;
        private int _itemQuantity;
        private List<LineItems> _lineItems = new List<LineItems>();
        public int LineItemId
        {
            get { return _lineItemId; }
            set { _lineItemId = value; }
        }
       
        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
            }
        }
        public string StoreAddress
        {
            get { return _storeAddress; }
            set
            {
                _storeAddress = value;
            }
        }


        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }
         public int PId
        {
            get { return _pId; }
            set { _pId = value; } 
        }

        public List<LineItems> LineItem
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }

        public override string ToString()
        {
            return $"Store Order ID: {LineItemId}\nProductName: {ProductName}\nProduct Quanitity: {ItemQuantity}\nStore Address: {StoreAddress}\nProductId{PId}";
        }

    }
}
