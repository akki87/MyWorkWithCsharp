using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IOrderRepository
	{
		public List<Order> GetAllaOrders();
		public Order GetOrderById(int id);
		public bool UpdateOrder(int id, Order record);
		public bool AddOrder(Order record);
		public bool RemoveOrder(int id);

	}
}
