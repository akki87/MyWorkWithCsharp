using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual FoodItem Item { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
