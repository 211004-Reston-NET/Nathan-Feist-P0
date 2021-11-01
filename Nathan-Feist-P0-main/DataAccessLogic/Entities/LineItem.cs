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
        }

        public int LineItemId { get; set; }
        public string ProductName { get; set; }
        public string OrderStoreFrontAddress { get; set; }
        public decimal QuantityNumber { get; set; }
        public int StoreOrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual StoreOrder StoreOrder { get; set; }
        public virtual ICollection<LineItemOrder> LineItemOrders { get; set; }
    }
}
