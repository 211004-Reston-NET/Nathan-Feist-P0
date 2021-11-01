using System;
using System.Collections.Generic;

#nullable disable

namespace userInterface.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int StoreOrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreLocationId { get; set; }
        public int UsersId { get; set; }

        public virtual User Users { get; set; }
        public virtual StoreLocation StoreLocations { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
