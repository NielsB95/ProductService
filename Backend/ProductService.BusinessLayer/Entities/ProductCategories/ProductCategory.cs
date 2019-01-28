using Newtonsoft.Json;
using ProductService.BusinessLayer.Entities.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.BusinessLayer.Entities.ProductCategories
{
	public class ProductCategory : Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		public string Name { get; set; }

		[JsonIgnore]
		public virtual IList<Product> Products { get; set; }
	}
}
