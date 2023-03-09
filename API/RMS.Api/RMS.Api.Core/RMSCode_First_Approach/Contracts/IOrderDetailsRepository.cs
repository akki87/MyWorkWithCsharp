using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IOrderDetailsRepository
	{
		public List<OrderDetail> GetAllOrderDetails();
		public OrderDetail GetOrderDetailById(int id);
		public bool AddOrderDetail(OrderDetail record);
		public bool UpdateOrderDetail(int id, OrderDetail record);
		public bool RemoveOrderDetail(int id);
	}
}
