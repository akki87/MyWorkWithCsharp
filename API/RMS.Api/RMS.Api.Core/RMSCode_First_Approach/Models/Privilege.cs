using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Privilege
    {
        public Privilege()
        {
            RolePrivilegeMaps = new HashSet<RolePrivilegeMap>();
        }

        public int PrivilegeId { get; set; }
        public string PrivilegeName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<RolePrivilegeMap> RolePrivilegeMaps { get; set; }
    }
}
