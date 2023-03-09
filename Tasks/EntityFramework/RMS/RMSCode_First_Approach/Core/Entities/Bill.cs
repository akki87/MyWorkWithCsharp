using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class Bill
    {
        [Key]
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Cname { get; set; } = null!;
        public string OrderItems { get; set; } = null!;
        public decimal TotalCost { get; set; }

        public Bill(int billId, int orderId, int customerId, string cname, string orderItems, decimal totalCost)
        {
            BillId = billId;
            OrderId = orderId;
            CustomerId = customerId;
            Cname = cname;
            OrderItems = orderItems;
            TotalCost = totalCost;
        }   
        public Bill() { }   
    }

}
