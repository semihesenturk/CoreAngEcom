using CoreAngEcom.Application.Repositories;
using CoreAngEcom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreAngEcom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //var result = _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Tencere", Price = 100, Stock = 10 },
            //    new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Tava", Price = 200, Stock = 20 },
            //    new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Bardak", Price = 300, Stock = 30 }
            //});

            //var count = await _productWriteRepository.SaveAsync();

            //Product product = await _productReadRepository.GetByIdAsync("c1ebac19-ce91-438e-ae31-8ad494aa7c98");
            //product.Name = "Bardak";

            //await _productWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }
}

