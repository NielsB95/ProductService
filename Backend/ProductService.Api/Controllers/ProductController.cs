using Microsoft.AspNetCore.Mvc;
using ProductService.BusinessLayer.Entities.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.API.Controllers
{
	[Route("Products")]
	[Produces("application/json")]
	public class ApplicationController : ControllerBase
	{
		private readonly IProductRepository productRepository;

		public ApplicationController(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		public async Task<ActionResult<IList<Product>>> GetAll()
		{
			var result = await this.productRepository.GetAll();
			return Ok(result);
		}
	}
}
