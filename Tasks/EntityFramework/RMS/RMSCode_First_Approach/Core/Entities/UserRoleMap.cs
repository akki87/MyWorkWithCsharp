using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class UserRoleMap
    {
        [Key]
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public UserRoleMap(int userRoleId, int roleId, int userId, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, bool? status)
        {
            UserRoleId = userRoleId;
            RoleId = roleId;
            UserId = userId;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Status = status;
        }
    
        public UserRoleMap() { }
    }
}
