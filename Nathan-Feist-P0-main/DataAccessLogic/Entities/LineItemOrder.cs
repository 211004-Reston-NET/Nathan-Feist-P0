using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItemOrder
    {
        public int LineitemOrderId { get; set; }
        public int StoreOrderId { get; set; }
        public int LineItemId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual StoreOrder StoreOrder { get; set; }
    }
}
