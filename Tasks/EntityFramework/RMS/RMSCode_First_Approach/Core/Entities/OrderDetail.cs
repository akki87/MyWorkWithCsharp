using System;
using System.Collections.Generic;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderDetail() { }    
        public OrderDetail(int orderId, int itemId, string itemName, int quantity, decimal price)
        {
            OrderId = orderId;
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }   
    }
}
