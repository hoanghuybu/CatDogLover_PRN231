using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class ReactType
    {
        public ReactType()
        {
            Reacts = new HashSet<React>();
        }

        public int ReactTypeId { get; set; }
        public string ReactType1 { get; set; }

        public virtual ICollection<React> Reacts { get; set; }
    }
}
