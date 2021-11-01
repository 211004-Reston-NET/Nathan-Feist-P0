using System;
using System.Collections.Generic;

#nullable disable

namespace userInterface.Entities
{
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public decimal QuantityNumber { get; set; }
        public int StoreOrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual StoreOrder StoreOrder { get; set; }
    }
}
