using CafeCore.Models.Enums;
using CafeCore.Models.Interface;

namespace CafeCore.Models.Models;

public class ProductFactory : IProductFactory
{
    /*
    public Product CreateProduct(string name, string? description, decimal price, Location location, string categoryName)
    {
        var category = GetOrCreateCategory(categoryName, location);
        var product = new Product(name, description, price, category);
        return product;
    }

    #region private

    private Category GetOrCreateCategory(string categoryName, Location location)
    {
        if (string.IsNullOrWhiteSpace(categoryName))
        {
            throw new ArgumentNullException(nameof(categoryName));
        }

        try
        {
            var category = GetCategory(categoryName);
            if (category == null)
            {
                category = CreateCategory(categoryName, location);
            }
            return category;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    private Category CreateCategory(string categoryName, Location location)
    {
        var category = new Category(categoryName, string.Empty, location);
        return category;
    }

    private Category GetCategory(string categoryName)
    {
        return null;
        throw new NotImplementedException();
    }

    #endregion
    */
}
