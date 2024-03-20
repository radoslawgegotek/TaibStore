using TaibStore.BLL.Dto.Product;

namespace TaibStore.BLL.Dto.Order
{
    public class OrderPositionResponseDto
    {
        public ProductResponseDto Product { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
