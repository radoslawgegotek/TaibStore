using TaibStore.BLL.Dto.Basket;

namespace TaibStore.BLL.IRepositories.Basket
{
    public interface IBasketRepository
    {
        List<BasketPositionResponseDto> GetBasketPositions(int UserId);
        void AddBasketPosition(BasketPositionRequestDto basketRequest);
        void DeleteBasketPosition(int basketId);
        void ChargeBasketPositionProductAmount(int basketId, int amount);
    }
}
