using Bll.Entities;
using Bll.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    // GET api/Product
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_productRepository.Get().ToList());
    }
    
    // GET api/Product/1
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Product? product = _productRepository.Get(id);
        return product is null ? NotFound() : Ok(product);
    }
}