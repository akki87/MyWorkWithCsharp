using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IFoodcategoryRepository
	{
		public List<FoodCategory> GetAllFoodCategories();
		public FoodCategory GetFoodCategoryById(int id);
		public bool AddFoodCategory(FoodCategory record);
		public bool UpdateFoodCategory(int id, FoodCategory record);
		public bool RemoveFoodCategory(int id);
	}
}
