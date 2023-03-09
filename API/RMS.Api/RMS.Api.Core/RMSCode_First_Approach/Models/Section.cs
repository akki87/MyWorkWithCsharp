using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Section
    {
        public Section()
        {
            DiningSets = new HashSet<DiningSet>();
        }

        public int SectionId { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Charges { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<DiningSet> DiningSets { get; set; }
    }
}
