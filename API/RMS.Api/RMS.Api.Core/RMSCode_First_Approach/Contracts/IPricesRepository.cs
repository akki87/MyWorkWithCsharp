using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IPricesRepository
	{
		public List<Price> GetAllPrices();
		public Price GetPrice(int id);
		public bool AddPrice(Price record);
		public bool UpdatePrice(int id, Price record);
		public bool RemovePrice(int id);
	}
}
