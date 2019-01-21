using System.ComponentModel.DataAnnotations;

namespace ProductService.BusinessLayer.Tests.Validation.TestEntities
{
	internal class TestEntity : Entity
	{
		[Key, Required]
		public int ID { get; set; }

		[MaxLength(10, ErrorMessage = "Name can't be this long")]
		public string Name { get; set; }
	}
}
