using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IFoodItemRepository
	{
		public List<FoodItem> GetAllFoodItems();
		public FoodItem GetFoodItemById(int id);
		public bool AddFoodItem(FoodItem record);
		public bool UpdateFoodItem(int id, FoodItem record);
		public bool RemoveFoodItem(int id);
	}
}
