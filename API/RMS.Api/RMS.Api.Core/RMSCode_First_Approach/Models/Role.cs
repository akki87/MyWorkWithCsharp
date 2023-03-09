using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePrivilegeMaps = new HashSet<RolePrivilegeMap>();
            UserRoleMaps = new HashSet<UserRoleMap>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<RolePrivilegeMap> RolePrivilegeMaps { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMaps { get; set; }
    }
}
