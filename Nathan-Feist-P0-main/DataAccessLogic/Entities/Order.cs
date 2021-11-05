using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public string StoreAddress { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ItemQuantity { get; set; }

    }
}
