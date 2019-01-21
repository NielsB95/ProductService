﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.BusinessLayer.Entities
{
	public class Product : Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid ID { get; set; }

		public string Name { get; set; }

		public int CategoryID { get; set; }
		public ProductCategory Category { get; set; }

		public IList<ProductStock> ProductStocks { get; set; }
		public IList<ProductPrice> ProductPrices { get; set; }
	}
}
