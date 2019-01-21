using ProductService.BusinessLayer.Entities.Products;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.BusinessLayer.Entities.ProductPrices
{
	public class ProductPrice : Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		/// <summary>
		/// The start datetime from which the price is introduced.
		/// </summary>
		public DateTime StartDate { get; set; }

		/// <summary>
		/// The new price for the Product.
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// The ID for the produc to which the new price should be applied.
		/// </summary>
		public Guid ProductID { get; set; }
		public Product Product { get; set; }
	}
}