using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public int PostId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageLink { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Post Post { get; set; }
    }
}
