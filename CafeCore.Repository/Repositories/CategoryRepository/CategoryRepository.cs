using CafeCore.Models.Models;

namespace CafeCore.Repositories.Repositories.CategoryRepository;

public class CategoryRepository : ICategoryRepository
{
    public Task<int> CreateCategory(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetCategoryByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
