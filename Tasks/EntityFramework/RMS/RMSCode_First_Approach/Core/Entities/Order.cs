using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMSCodeFirstApproach.RMS.Core.Entities
{
    public partial class Order
    {

        [Key]
        public int OrderId { get; set; }
        public int DiningSetId { get; set; }
        public int ChefId { get; set; }
        public int WaiterId { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; } = null!;
        public bool? Status { get; set; }

       public Order(int orderId, int diningSetId, int chefId, int waiterId, int customerId, string orderStatus, bool? status)
        {
            OrderId = orderId;
            DiningSetId = diningSetId;
            ChefId = chefId;
            WaiterId = waiterId;
            CustomerId = customerId;
            OrderStatus = orderStatus;
            Status = status;
        }   
        public Order() { }  

    }
}
