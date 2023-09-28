using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
        public string ItemId { get; set; }
        public string ShipAddress { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
