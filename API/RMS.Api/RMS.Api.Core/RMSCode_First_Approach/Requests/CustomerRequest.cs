namespace RMS.Api.Core.RequestAndResonse
{
	public class CustomerRequest
	{
		public int PageSize { get; set; }
		public int PageNumber { get; set; }
		public string? SortBy { get; set; }
		public string? SortOrder { get; set; }
	}
}
