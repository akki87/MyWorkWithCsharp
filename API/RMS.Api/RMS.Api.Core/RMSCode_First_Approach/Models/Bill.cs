using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Bill
    {
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string OrderItems { get; set; } = null!;
        public decimal TotalCost { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Customer CustomerNameNavigation { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
