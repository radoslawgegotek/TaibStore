using TaibStore.BLL.Dto.Product;

namespace TaibStore.BLL.Dto.Basket
{
    public class BasketPositionResponseDto
    {
        public int ID { get; set; }
        public ProductResponseDto Product { get; set; }
        public int Amount { get; set; }
    }
}
