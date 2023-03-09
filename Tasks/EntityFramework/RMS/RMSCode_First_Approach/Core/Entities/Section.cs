using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class Section
    {
       
        [Key]
        public int SectionId { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Charges { get; set; }

        public Section(string name, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, int charges)
        {
            //SectionId = sectionId;
            Name = name;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Charges = charges;
        }
        public Section()
        {
        }

    }
}
