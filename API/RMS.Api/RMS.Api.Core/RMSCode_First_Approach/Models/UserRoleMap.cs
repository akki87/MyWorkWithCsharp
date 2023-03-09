using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class UserRoleMap
    {
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
