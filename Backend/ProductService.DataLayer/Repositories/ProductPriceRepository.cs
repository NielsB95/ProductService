using ProductService.BusinessLayer.Entities.ProductPrices;
using ProductService.DataLayer.Context;

namespace ProductService.DataLayer.Repositories
{
	public class ProductPriceRepository : Repository<ProductPrice>, IProductPriceRepository
	{
		public ProductPriceRepository(ProductServiceContext context) : base(context)
		{
		}
	}
}
