using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class ServiceScheduler
    {
        public string ServiceSchedulerId { get; set; }
        public string ServiceId { get; set; }
        public decimal Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Status { get; set; }

        public virtual Service Service { get; set; }
    }
}
