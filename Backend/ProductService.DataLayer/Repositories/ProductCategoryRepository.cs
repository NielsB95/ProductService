using ProductService.BusinessLayer.Entities.ProductCategories;
using ProductService.DataLayer.Context;

namespace ProductService.DataLayer.Repositories
{
	public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
	{
		public ProductCategoryRepository(ProductServiceContext context) : base(context)
		{
		}
	}
}
