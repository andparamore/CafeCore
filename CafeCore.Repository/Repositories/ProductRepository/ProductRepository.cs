using CafeCore.Data.Context;
using CafeCore.Models.Interface;
using CafeCore.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CafeCore.Repositories.Repositories.ProductRepository;

public class ProductRepository : IProductRepository
{
    private readonly ProductContext _dbContext;
    public ProductRepository(ProductContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _dbContext.Products.AsNoTracking().ToListAsync();
    }

    public async Task<int> AddProductAsync(Product product)
    {
        _ = _dbContext.Products.Add(product);

        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteProductAsync(int productId)
    {
        if (!_dbContext.Products.Any(x => x.Id == productId))
        {
            return 0;
        }

        _dbContext.Remove(_dbContext.Products.Single(x => x.Id == productId));

        return await _dbContext.SaveChangesAsync();
    }

    public async Task<Product?> GetProductByIdAsync(int guid)
    {
        return await _dbContext.Products.AsNoTracking().SingleOrDefaultAsync(x => x.Id == guid);
    }

    

    public async Task<int> UpdateProductAsync(Product product)
    {
        if (!_dbContext.Products.Any(x => x.Id == product.Id))
        {
            return 0;
        }

        _dbContext.Update(product);

        return await _dbContext.SaveChangesAsync();
    }
}