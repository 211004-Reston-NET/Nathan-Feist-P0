using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int LineItemId { get; set; }
        public int UserId { get; set; }
        public Int32 StoreAddress { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual StoreLocation StoreAddressNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
