using System;
using System.Collections.Generic;

namespace RMSCodeFirstApproach.RMS.Core.Entities
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
        

        public Price() { }
        public Price(int itemId, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, decimal price1, bool? status)
        {
            ItemId = itemId;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Price1 = price1;
            Status = status;
        }   
    }
}
