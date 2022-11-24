using CafeCore.Models.Models;

namespace CafeCore.Repositories.Repositories.CategoryRepository;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
    Task<Category> GetCategoryByIdAsync(int id);
    Task<int> CreateCategory(Category category);
}
