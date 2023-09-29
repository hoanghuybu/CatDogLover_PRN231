using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Item
    {
        public Item()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string ItemId { get; set; }
        public int Price { get; set; }

        public virtual Product Product { get; set; }
        public virtual ServiceScheduler ServiceScheduler { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
