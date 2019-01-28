using Microsoft.EntityFrameworkCore;
using ProductService.BusinessLayer.Entities.Products;
using ProductService.DataLayer.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.DataLayer.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(ProductServiceContext context) : base(context)
		{
		}

		/// <summary>
		/// Overriden implementation of GetAll which includes the Category of
		/// each producet.
		/// </summary>
		/// <returns></returns>
		public override async Task<IList<Product>> GetAll()
		{
			var result = this.context.Products
				.Include(x => x.Category)
				.ToAsyncEnumerable();

			return await result.ToList();
		}
	}
}
