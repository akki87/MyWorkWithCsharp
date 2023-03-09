using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using RMSCodeFirstApproach.Core.Entities;
using RMSCodeFirstApproach.RMS.Core.Entities;

namespace RMSCodeFirstApproach.Context
{
    public class RMSContext : DbContext
    {
        public RMSContext()
        {
        }

        public RMSContext(DbContextOptions<RMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<FoodItem> FoodItems { get; set; } = null!;
        public virtual DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<DiningSet> DiningSets { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRoleMap> UserRoleMap { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
		public virtual DbSet<Employee> Employees { get; set; } = null!;


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=RMS;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FoodItem>().ToTable("FoodItem");
            modelBuilder.Entity<FoodCategory>().ToTable("FoodCategory");
            modelBuilder.Entity<UserRoleMap>().ToTable("UserRoleMap");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Bill>().ToTable("Bill");
            modelBuilder.Entity<DiningSet>().ToTable("DiningSet");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail").HasNoKey();
            modelBuilder.Entity<Price>().ToTable("Price").HasNoKey();
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Section>().ToTable("Section");
			modelBuilder.Entity<Employee>().ToTable("Employee");
			//modelBuilder.Entity<Customer>(u => {
			//    u.Property(p => p.Cname).HasComputedColumnSql("('CUST'+cast(IDENT_CURRENT( 'Customer' )");
			//});
		}
      
    }
}
