using Microsoft.EntityFrameworkCore;
using ProductService.BusinessLayer.Entities.ProductCategories;
using ProductService.BusinessLayer.Entities.ProductPrices;
using ProductService.BusinessLayer.Entities.Products;
using ProductService.BusinessLayer.Entities.ProductStocks;

namespace ProductService.DataLayer.Context
{
	public class ProductServiceContext : DbContext
	{
		public ProductServiceContext()
		{
		}

		public ProductServiceContext(DbContextOptions<ProductServiceContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Only configure if it hasn't been configured yet. We are probably
			// running unit tests if it hasn't been configured.
			if (!optionsBuilder.IsConfigured)
				base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<ProductPrice> ProductPrices { get; set; }
		public DbSet<ProductStock> ProductStocks { get; set; }
	}
}
