using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Price
    {
        public int ItemId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal Price1 { get; set; }
        public bool? Status { get; set; }
    }
}
