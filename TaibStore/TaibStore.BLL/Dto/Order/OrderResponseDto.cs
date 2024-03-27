namespace TaibStore.BLL.Dto.Order
{
    public class OrderResponseDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderPositionResponseDto> OrderPositions { get; set; }
    }
}
