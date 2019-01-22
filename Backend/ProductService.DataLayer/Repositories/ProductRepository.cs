using ProductService.BusinessLayer.Entities.Products;
using ProductService.DataLayer.Context;

namespace ProductService.DataLayer.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(ProductServiceContext context) : base(context)
		{
		}
	}
}
