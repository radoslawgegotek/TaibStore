using Microsoft.EntityFrameworkCore;
using TaibStore.BLL.Dto;
using TaibStore.BLL.Dto.Product;
using TaibStore.BLL.IRepositories.Product;
using TaibStore.DataAccess.Context;
using TaibStore.Model.Models;

namespace TaibStore.BLL.EF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebStoreContext _context;

        public ProductRepository(WebStoreContext context)
        {
            _context = context;
        }

        public async void AddProduct(ProductRequestDto productRequest)
        {
            if(productRequest.Price > 0 )
            {
                await _context.Products.AddAsync(new Product()
                {
                    Name = productRequest.Name,
                    Price = productRequest.Price,
                    Image = productRequest.Image,
                    IsActive = productRequest.IsActive
                });
                await _context.SaveChangesAsync();
            }
        }

        public async void ChangeProductStatus(int productId, bool activated)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ID == productId);
            if(product != null)
            {
                product.IsActive = activated;
                await _context.SaveChangesAsync();
            }
        }

        public async void DeleteProduct(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ID == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            await _context.SaveChangesAsync();
        }

        public ProductResponseDto GetProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            
            if (product == null) return null;

            return new ProductResponseDto()
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                Image = product.Image,
            };
        }

        public List<ProductResponseDto> GetProducts(PageProperties pageProperties) //TO DO
        {
            int offset = pageProperties.PageNumber - 1 * pageProperties.PageSize;

            if (pageProperties.FilterByName && pageProperties.Ascending)
                return _context.Products
                    .OrderBy(x => x.Name)
                    .Skip(offset)
                    .Take(pageProperties.PageSize)
                    .Select(x => new ProductResponseDto()
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Price = x.Price,
                        Image = x.Image,
                    }).ToList();
            else
                return _context.Products
                    .OrderByDescending(x => x.Name)
                    .Skip(offset)
                    .Take(pageProperties.PageSize)
                    .Select(x => new ProductResponseDto()
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Price = x.Price,
                        Image = x.Image,
                    }).ToList();
        }

        public async void UpdateProduct(int productId, ProductRequestDto productRequest)
        {
            if (productRequest.Price > 0)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.ID == productId);

                if (product != null)
                {
                    product.Name = productRequest.Name;
                    product.Price = productRequest.Price;
                    product.IsActive = productRequest.IsActive;
                    product.Image = productRequest.Image;
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
