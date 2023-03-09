using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RMSCodeFirstApproach.Core.Entities;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class FoodCategory
    {

        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }

       public FoodCategory(int categoryId, string name, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, bool? status)
        {
            CategoryId = categoryId;
            Name = name;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Status = status;
        }   
        public FoodCategory() { }

    }
}
