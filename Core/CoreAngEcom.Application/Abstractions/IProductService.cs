using CoreAngEcom.Domain.Entities;

namespace CoreAngEcom.Application.Abstractions
{
    public interface IProductService
	{
		List<Product> GetProducts();
	}
}

