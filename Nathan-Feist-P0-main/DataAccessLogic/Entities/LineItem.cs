using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            LineItemOrders = new HashSet<LineItemOrder>();
            Orders = new HashSet<Order>();
        }

        public int LineItemId { get; set; }
        public decimal QuantityNumber { get; set; }
        public int StoreOrderId { get; set; }
        public int ProductId { get; set; }
        public int LineItemQuantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<LineItemOrder> LineItemOrders { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
