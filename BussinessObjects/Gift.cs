using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Gift
    {
        public Gift()
        {
            GiftComments = new HashSet<GiftComment>();
        }

        public string GiftId { get; set; }
        public string GiftName { get; set; }
        public string Description { get; set; }
        public int PostId { get; set; }
        public string ImageLink { get; set; }
        public bool Status { get; set; }

        public virtual Post Post { get; set; }
        public virtual ICollection<GiftComment> GiftComments { get; set; }
    }
}
