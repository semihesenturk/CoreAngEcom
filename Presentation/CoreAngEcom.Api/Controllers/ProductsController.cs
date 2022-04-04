
using CoreAngEcom.Application.Repositories;
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
        public async void Get()
        {
            var result = _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Tencere", Price = 100, Stock = 10 },
                new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Tava", Price = 200, Stock = 20 },
                new() { Id = Guid.NewGuid(), CretedDate = DateTime.UtcNow, IsActive = true, Name = "Bardak", Price = 300, Stock = 30 }
            });

            var count = await _productWriteRepository.SaveAsync();
        }

    }
}

