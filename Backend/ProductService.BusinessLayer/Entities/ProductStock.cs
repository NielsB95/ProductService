using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.BusinessLayer.Entities
{
	public class ProductStock : Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		/// <summary>
		/// The delta with which the stock of a certain property is changed.
		/// </summary>
		public int Delta { get; set; }

		public Guid ProductID { get; set; }
		public Product Product { get; set; }
	}
}
