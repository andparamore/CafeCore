using CafeCore.Models.Models;
using CafeCore.Repositories.Repositories.ProductRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CafeCore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;;;;;;;;;;;;;;;;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    [Route("get_all_products")]
    public async Task<IActionResult> GetAllProducts()
    {
        try
        {
            var result = await _productRepository.GetAllProductsAsync();
            return Ok(result);
        }
        catch (Exception e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }

    [HttpGet]
    [Route("get_product_by_id")]
    public async Task<IActionResult> GetProductById(int id)
    {
        try
        {
            if (id == 0)
            {
                return BadRequest(nameof(id));
            }

            var result = await _productRepository.GetProductByIdAsync(id);
            return result is null ? Ok(result)
                : NotFound("Product isn't found in database");
        }
        catch (Exception e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }

    [HttpPost]
    [Route("create_product")]
    public async Task<IActionResult> CreateProduct(Product product)
    {
        try
        {
            /*
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                return BadRequest(nameof(categoryName));
            }
            

            var factory = new ProductFactory();
            var product = factory.CreateProduct(name, description, price, location, categoryName);
            */

            _ = await _productRepository.AddProductAsync(product);
            var result = await _productRepository.GetProductByIdAsync(product.Id);
            return Ok(result);
        }
        catch (Exception e)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        }
    }
}
