using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItemOrder
    {
        public int LineItemOrderId { get; set; }
        public int? LineItemLineItemId { get; set; }

        public virtual LineItem LineItemLineItem { get; set; }
    }
}
