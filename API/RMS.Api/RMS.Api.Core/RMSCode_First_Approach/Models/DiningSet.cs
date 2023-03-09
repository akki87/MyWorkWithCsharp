using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class DiningSet
    {
        public DiningSet()
        {
            Orders = new HashSet<Order>();
        }

        public int DiningSetId { get; set; }
        public int ChairCount { get; set; }
        public int SectionId { get; set; }
        public bool? Status { get; set; }

        public virtual Section Section { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
