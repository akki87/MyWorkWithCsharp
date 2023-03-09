using RMS.Api.Core.Models;

namespace RMS.Api.Core.Responses
{
	public class CustomerResponse
	{
		public List<Customer> CustomerList { get; set; }
		public int TotalRecords { get; set; }
		public int PageSize { get; set; }
		public int PageNumber { get; set; }
	}
}
