namespace RMS.Api.Core.Models
{
    public partial class Customer
    {
        public Customer()
        {
            BillCustomerNameNavigations = new HashSet<Bill>();
            BillCustomers = new HashSet<Bill>();
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string Cname { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<Bill> BillCustomerNameNavigations { get; set; }
        public virtual ICollection<Bill> BillCustomers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
