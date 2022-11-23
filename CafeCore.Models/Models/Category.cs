using CafeCore.Models.Enums;
using CafeCore.Models.Interface;

namespace CafeCore.Models.Models;

public class Category
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string? Description { get; set; }
    public Location Location { get; init; }
    public ICollection<Product> Products { get; set; }

    /*
    public Category(string name, string? description, Location location)
    {
        Name = name;
        Description = description;
        Location = location;
    }
    */
}
