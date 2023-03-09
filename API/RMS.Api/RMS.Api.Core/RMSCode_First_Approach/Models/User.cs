using System.Text.Json.Serialization;

using RMS.Api.Core.Models;

namespace RMS.Api.Core.Models
{
    public partial class User
    {
        public User()
        {
            CustomerCreatedByNavigations = new HashSet<Customer>();
            CustomerModifiedByNavigations = new HashSet<Customer>();
            FoodCategoryCreatedByNavigations = new HashSet<FoodCategory>();
            FoodCategoryModifiedByNavigations = new HashSet<FoodCategory>();
            FoodItemCreatedByNavigations = new HashSet<FoodItem>();
            FoodItemModifiedByNavigations = new HashSet<FoodItem>();
            OrderChefs = new HashSet<Order>();
            OrderWaiters = new HashSet<Order>();
            PrivilegeCreatedByNavigations = new HashSet<Privilege>();
            PrivilegeModifiedByNavigations = new HashSet<Privilege>();
            RoleCreatedByNavigations = new HashSet<Role>();
            RoleModifiedByNavigations = new HashSet<Role>();
            RolePrivilegeMapCreatedByNavigations = new HashSet<RolePrivilegeMap>();
            RolePrivilegeMapModifiedByNavigations = new HashSet<RolePrivilegeMap>();
            SectionCreatedByNavigations = new HashSet<Section>();
            SectionModifiedByNavigations = new HashSet<Section>();
            UserRoleMapCreatedByNavigations = new HashSet<UserRoleMap>();
            UserRoleMapModifiedByNavigations = new HashSet<UserRoleMap>();
            UserRoleMapUsers = new HashSet<UserRoleMap>();
        }

		public int UserId { get; set; }
		public string Name { get; set; } = null!;
		public string Phone { get; set; } = null!;
		public string Uname { get; set; } = null!;
		public string Password { get; set; } = null!;
		public int CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public int ModifiedBy { get; set; }
		public DateTime ModifiedDate { get; set; }
		public bool? Status { get; set; }
		[JsonIgnore]
		public virtual ICollection<Customer> CustomerCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Customer> CustomerModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<FoodCategory> FoodCategoryCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<FoodCategory> FoodCategoryModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<FoodItem> FoodItemCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<FoodItem> FoodItemModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> OrderChefs { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> OrderWaiters { get; set; }
        [JsonIgnore]
        public virtual ICollection<Role> RoleCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Role> RoleModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Section> SectionCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<Section> SectionModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserRoleMap> UserRoleMapCreatedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserRoleMap> UserRoleMapModifiedByNavigations { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserRoleMap> UserRoleMapUsers { get; set; }
	}
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Uname { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Customer> CustomerCreatedByNavigations { get; set; }
        public virtual ICollection<Customer> CustomerModifiedByNavigations { get; set; }
        public virtual ICollection<FoodCategory> FoodCategoryCreatedByNavigations { get; set; }
        public virtual ICollection<FoodCategory> FoodCategoryModifiedByNavigations { get; set; }
        public virtual ICollection<FoodItem> FoodItemCreatedByNavigations { get; set; }
        public virtual ICollection<FoodItem> FoodItemModifiedByNavigations { get; set; }
        public virtual ICollection<Order> OrderChefs { get; set; }
        public virtual ICollection<Order> OrderWaiters { get; set; }
        public virtual ICollection<Privilege> PrivilegeCreatedByNavigations { get; set; }
        public virtual ICollection<Privilege> PrivilegeModifiedByNavigations { get; set; }
        public virtual ICollection<Role> RoleCreatedByNavigations { get; set; }
        public virtual ICollection<Role> RoleModifiedByNavigations { get; set; }
        public virtual ICollection<RolePrivilegeMap> RolePrivilegeMapCreatedByNavigations { get; set; }
        public virtual ICollection<RolePrivilegeMap> RolePrivilegeMapModifiedByNavigations { get; set; }
        public virtual ICollection<Section> SectionCreatedByNavigations { get; set; }
        public virtual ICollection<Section> SectionModifiedByNavigations { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMapCreatedByNavigations { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMapModifiedByNavigations { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMapUsers { get; set; }
    }
}
