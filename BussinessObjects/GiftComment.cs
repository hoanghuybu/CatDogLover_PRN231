using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class GiftComment
    {
        public int GiftCommentId { get; set; }
        public string GiftId { get; set; }
        public int AccountId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Gift Gift { get; set; }
    }
}
