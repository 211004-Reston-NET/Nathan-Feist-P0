using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Order
    {
        public int StoreOrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreLocationId { get; set; }
        public int UsersId { get; set; }
    }
}
