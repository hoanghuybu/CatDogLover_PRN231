using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObjects
{
    public partial class Account
    {
        public Account()
        {
            GiftComments = new HashSet<GiftComment>();
            Orders = new HashSet<Order>();
            Posts = new HashSet<Post>();
            Reacts = new HashSet<React>();
        }

        public int AccountId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int RoleId { get; set; }
        public string Phone { get; set; }
        public string BanReason { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }
        public string AvatarLink { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<GiftComment> GiftComments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<React> Reacts { get; set; }
    }
}
