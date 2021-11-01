using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public decimal QuantityNumber { get; set; }
        public int StoreOrderId { get; set; }
        public int ProductId { get; set; }
    }
}
