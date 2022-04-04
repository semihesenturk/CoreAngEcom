using CoreAngEcom.Application.Abstractions;
using CoreAngEcom.Domain.Entities;

namespace CoreAngEcom.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name ="Tava",
                Price =100,
                Stock =2,
                CretedDate = DateTime.Now,
                IsActive = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Tencere",
                Price = 200,
                Stock = 2,
                CretedDate = DateTime.Now,
                IsActive = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Cezve",
                Price = 50,
                Stock = 2,
                CretedDate = DateTime.Now,
                IsActive = true
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Kapak",
                Price = 10,
                Stock = 2,
                CretedDate = DateTime.Now,
                IsActive = true
            }
        };
    }
}

