using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public class Customer
    {
        public Customer() { }
        public Customer(string? name, string? address, string? phone,string cname,int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate)
        {
            Name = name;
            Address = address;
            Phone = phone;
            CName = cname;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
        }
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }  
    }
}
