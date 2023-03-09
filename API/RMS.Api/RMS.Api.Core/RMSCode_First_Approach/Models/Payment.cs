using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Payment
    {
        public decimal? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? StoreId { get; set; }
    }
}
