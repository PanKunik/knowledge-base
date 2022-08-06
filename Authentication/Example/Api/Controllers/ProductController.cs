using Authentication.Example.Entities;
using Authentication.Example.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Example.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _productRepository.GetAll();
    }

    [HttpPost]
    [Authorize]
    public IActionResult Post(Product product)
    {
        _productRepository.AddProduct(product);
        return Ok();
    }
}