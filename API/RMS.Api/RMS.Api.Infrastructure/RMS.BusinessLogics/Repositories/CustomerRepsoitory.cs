using RMS.Api.Core.Contracts;
using RMS.Api.Core.Models;
using RMS.Api.Infrastructure.Data.Context;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace RMS.Api.Infrastructure.Repositories
{
	public class CustomerRepsoitory : ICustomerRepository
	{
		public static RMSContext Context ;

		public CustomerRepsoitory(RMSContext context)
		{
			Context = context;	
		}

        public CustomerRepsoitory(RMSContext context)
        {
            _context = context;
        }

        public int CustomersCount
		{
			get { return _context.Customers.Count(); } 
		}

		public async Task<bool> UpdateCustomer(int id, Customer args)
		{
			var customerToUpdate =  _context.Customers.Find(id);

			customerToUpdate.Name= args.Name;
			customerToUpdate.Address=args.Address;
			customerToUpdate.Phone=args.Phone;
			customerToUpdate.Cname=args.Cname;
			customerToUpdate.CreatedBy=args.CreatedBy;
			customerToUpdate.CreatedDate=args.CreatedDate;
			customerToUpdate.ModifiedBy=args.ModifiedBy;
			customerToUpdate.ModifiedDate=args.ModifiedDate;
			_context.Customers.Update(customerToUpdate);
			_context.SaveChangesAsync();
			return true;
		}
		public async Task<Customer> GetCustomerById(int id)
		{
			return _context.Customers.Find(id);
		}
		public async Task<Customer> GetCustomerByMobileNumber(string MobileNumber)
		{
			return _context.Customers.FirstOrDefault(_ => _.Phone == MobileNumber);
		}
		public async Task<bool> AddCustomer(Customer args)
		{

			var customer = new Customer()
			{
				Name= args.Name,
				Address=args.Address,
				Phone=args.Phone,
				Cname=args.Cname,
				CreatedBy=args.CreatedBy,
				CreatedDate=args.CreatedDate,
				ModifiedBy=args.ModifiedBy,
				ModifiedDate=args.ModifiedDate

			};
			_context.Customers.Add(customer);
			_context.SaveChangesAsync();
			return true;
		}
		public async Task<bool> RemoveCustomer(int id)
		{
			Customer? customer = _context.Customers.Find(id);
			_context.Customers.Remove(customer);
			_context.SaveChangesAsync();
			return true;
		}
		public async Task<List<Customer>> GetAllCustomers()
		{

			return _context.Customers.ToList();
		}
		public virtual  async Task<List<Customer>> GetAllCustomers(int? page = 1,
		   int? pageSize = 10,
		string? sortColumn = null,
		   string sortOrder = "Asc",
		string? includeProperties = null,
		   params Expression<Func<Customer, bool>>[] filter)
		{
			IQueryable<Customer> tabledata = _context.Customers;
			foreach (var item in filter)
			{
				if (filter != null)
				{
					tabledata = tabledata.Where(item);
				}
			}
			//tabledata = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
			//.Aggregate(tabledata, (current, includeProperty) => current.Include(includeProperty));

			if (!string.IsNullOrEmpty(sortColumn))
			{
				if (!string.IsNullOrEmpty(sortOrder) && sortOrder.ToLower().Contains("Asc".ToLower()))
				{
					tabledata = tabledata.OrderBy(sortColumn);
				}
				else
				{
					tabledata = tabledata.OrderBy(sortColumn).Reverse();
				}
			}
			if (tabledata.Count() < pageSize) page = 1;
			if (page != null && pageSize != null)
				tabledata = tabledata
					.Skip((page.Value - 1) * pageSize.Value)
					.Take(pageSize.Value);

			return tabledata.ToList();

		}
	}
}
