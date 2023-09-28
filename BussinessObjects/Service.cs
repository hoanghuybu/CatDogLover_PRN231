﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Service
    {
        public Service()
        {
            ServiceSchedulers = new HashSet<ServiceScheduler>();
        }

        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int PostId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string ImageLink { get; set; }
        public string Address { get; set; }

        public virtual Post Post { get; set; }
        public virtual ICollection<ServiceScheduler> ServiceSchedulers { get; set; }
    }
}
