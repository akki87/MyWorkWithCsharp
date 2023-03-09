using RMS.Api.Core.Models;
using System.Linq.Expressions;

namespace RMS.Api.Core.Contracts
{
	public interface ICustomerRepository
	{

		public int CustomersCount { get;}

		public Task<bool> UpdateCustomer(int id, Customer customer);
		public Task<bool> RemoveCustomer(int id);
		public Task<bool> AddCustomer(Customer customer);
		public Task<Customer> GetCustomerById(int id);
		public Task<List<Customer>> GetAllCustomers();
		public Task<Customer> GetCustomerByMobileNumber(string mobileNumber);
		public Task<List<Customer>> GetAllCustomers(int? page = 1,
		   int? pageSize = 10,
		string? sortColumn = null,
		   string sortOrder = "Asc",
		string? includeProperties = null,
		   params Expression<Func<Customer, bool>>[] filter);
	}
}
