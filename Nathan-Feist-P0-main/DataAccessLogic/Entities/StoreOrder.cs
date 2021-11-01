using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class StoreOrder
    {
        public StoreOrder()
        {
            LineItemOrders = new HashSet<LineItemOrder>();
            LineItems = new HashSet<LineItem>();
        }

        public int StoreOrderId { get; set; }
        public string StoreFrontAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreFrontId { get; set; }
        public int CustomersId { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<LineItemOrder> LineItemOrders { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
