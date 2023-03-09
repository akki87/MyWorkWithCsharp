using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Order
    {
        public Order()
        {
            Bills = new HashSet<Bill>();
        }

        public int OrderId { get; set; }
        public int DiningSetId { get; set; }
        public int ChefId { get; set; }
        public int WaiterId { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; } = null!;
        public bool? Status { get; set; }

        public virtual User Chef { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual DiningSet DiningSet { get; set; } = null!;
        public virtual User Waiter { get; set; } = null!;
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
