using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Models
{
    public class LineItems
    {
        private int _lineItemId;
        private string _productName;
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

        public List<LineItems> LineItem
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }

        public override string ToString()
        {
            return $"Store Order ID: {LineItemId}ProductName: {ProductName} \nProduct Quanitity: {ItemQuantity} \nStore Address: {StoreAddress} \n";
        }

    }
}
