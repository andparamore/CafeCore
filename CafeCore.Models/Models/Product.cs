using CafeCore.Models.Interface;

namespace CafeCore.Models.Models;

public class Product
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; }

    /*
    public Product(string name, string? description, decimal price, Category category)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
    */
}
