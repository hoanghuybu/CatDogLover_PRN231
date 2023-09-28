using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
