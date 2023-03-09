using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IDiningSetRepository
	{
		public List<DiningSet> GetAllDiningSet();
		public DiningSet GetDiningSetById(int id);
		public bool AddDiningSet(DiningSet record);
		public bool UpdateDiningSet(int id, DiningSet record);
		public bool DeleteDiningSet(int id);

	}
}
