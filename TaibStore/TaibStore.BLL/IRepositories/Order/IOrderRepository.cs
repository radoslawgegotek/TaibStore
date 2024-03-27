using TaibStore.BLL.Dto.Order;

namespace TaibStore.BLL.IRepositories.Order
{
    public interface IOrderRepository
    {
        void CreateOrder(int UsertId);
        List<OrderResponseDto> GetAllOrders();
        List<OrderResponseDto> GetUserOrders(int UserId);
        List<OrderPositionResponseDto> GetOrderPositions(int OrderId);
    }
}
