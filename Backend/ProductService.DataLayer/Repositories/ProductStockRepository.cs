using ProductService.BusinessLayer.Entities.ProductStocks;
using ProductService.DataLayer.Context;

namespace ProductService.DataLayer.Repositories
{
	public class ProductStockRepository : Repository<ProductStock>, IProductStockRepository
	{
		public ProductStockRepository(ProductServiceContext context) : base(context)
		{
		}
	}
}
