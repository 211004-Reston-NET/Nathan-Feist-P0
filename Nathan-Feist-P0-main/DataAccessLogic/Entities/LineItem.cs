using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public int ProductId { get; set; }
        public int ItemQuantity { get; set; }
        public string ProductName { get; set; }
        public string StoreAddress { get; set; }

        public virtual Product Product { get; set; }
    }
}
