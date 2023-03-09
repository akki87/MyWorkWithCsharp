using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSCodeFirstApproach.Core.Entities
{
    public  class FoodItem
    {
        [Key]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int CategoryID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public FoodItem(string name, string details, int categoryID, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, bool status, decimal price)
        {
            //ItemID = itemID;
            Name = name;
            Details = details;
            CategoryID = categoryID;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Status = status;
            Price = price;
        }
        public FoodItem() { }

    }
}
