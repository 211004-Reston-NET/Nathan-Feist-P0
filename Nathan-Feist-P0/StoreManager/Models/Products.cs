using System;
using System.Collections.Generic;

namespace Models
{
    public class Products
    {
        int _referenceNumber;
        string _name;
        int _price;
        int _stock;


        public string ReferenceNumber { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        public override string ToString()
        {
            string product =
            $@"Product Info:
                Product Number: {ReferenceNumber}
                Name: {Name}
                Price: {Price}
                Item Stock {Stock}
                ";

            return product;
        }
    }
}

