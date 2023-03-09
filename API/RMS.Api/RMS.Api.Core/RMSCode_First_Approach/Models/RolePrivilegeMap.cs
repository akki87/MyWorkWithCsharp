using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class RolePrivilegeMap
    {
        public int PrivilegeRoleId { get; set; }
        public int? RoleId { get; set; }
        public int? PrivilegeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual Privilege? Privilege { get; set; }
        public virtual Role? Role { get; set; }
    }
}
