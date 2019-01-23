using GraphQL.Types;
using ProductService.BusinessLayer.Entities.Products;

namespace ProductService.GraphQL
{
	public class SchemaRegistration
	{
	}

	public class ProductType : ObjectGraphType<Product>
	{
		public ProductType()
		{
			Field(x => x.ID).Description("ID of a product");
			Field(x => x.Name).Description("Name of a product");
		}
	}

	public class ProductServiceGraph : ObjectGraphType
	{
		public ProductServiceGraph()
		{
			Field<ProductType>("Product", resolve: context => new Product() { Name = "Stickers" });
		}
	}

}
