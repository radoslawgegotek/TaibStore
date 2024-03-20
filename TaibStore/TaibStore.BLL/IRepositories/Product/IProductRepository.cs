using TaibStore.BLL.Dto;
using TaibStore.BLL.Dto.Product;

namespace TaibStore.BLL.IRepositories.Product
{
    public interface IProductRepository
    {
        List<ProductResponseDto> GetProducts(PageProperties pageProperties);
        ProductResponseDto GetProduct(int productId);
        void AddProduct(ProductRequestDto productRequest);
        void UpdateProduct(int productId, ProductRequestDto productRequest);
        void DeleteProduct(int productId);
        void ChangeProductStatus(int productId, bool activated);
    }
}
