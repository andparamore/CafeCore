using CafeCore.Models.Models;

namespace CafeCore.Repositories.Repositories.ProductRepository;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();

    Task<Product?> GetProductByIdAsync(int guid);

    Task<int> AddProductAsync(Product product);

    Task<int> UpdateProductAsync(Product product);

    Task<int> DeleteProductAsync(int productId);
}
