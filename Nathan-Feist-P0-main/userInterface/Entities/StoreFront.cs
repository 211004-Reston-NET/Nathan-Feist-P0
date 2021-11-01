using System;
using System.Collections.Generic;

#nullable disable

namespace userInterface.Entities
{
    public partial class StoreFront
    {
        public StoreFront()
        {
            StoreOrders = new HashSet<StoreOrder>();
        }

        public int StoreFrontId { get; set; }
        public string StoreFrontName { get; set; }
        public string StoreFrontAddress { get; set; }
        public int StoreFrontPhone { get; set; }

        public virtual ICollection<StoreOrder> StoreOrders { get; set; }
    }
}
