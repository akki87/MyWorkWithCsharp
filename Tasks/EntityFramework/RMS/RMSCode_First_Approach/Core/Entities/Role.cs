using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class Role
    {

        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }
        public Role(int roleId, string roleName, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, bool? status)
        {
            RoleId = roleId;
            RoleName = roleName;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Status = status;
        }
    
        public Role() { }
        
    }
}
