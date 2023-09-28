using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class React
    {
        public int AccountId { get; set; }
        public int PostId { get; set; }
        public int ReactTypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Post Post { get; set; }
        public virtual ReactType ReactType { get; set; }
    }
}
