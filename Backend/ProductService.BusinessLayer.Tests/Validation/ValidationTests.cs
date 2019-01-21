using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductService.BusinessLayer.Tests.Validation.TestEntities;
using System.Linq;

namespace ProductService.BusinessLayer.Tests.Validation
{
	[TestClass]
	public class ValidationTests
	{
		[TestMethod]
		public void ValidValidationTest()
		{
			var entity = new TestEntity()
			{
				ID = 1,
				Name = "Peter"
			};

			Assert.IsTrue(entity.IsValid());
		}

		[TestMethod]
		public void InvalidValidationTest()
		{
			var entity = new TestEntity()
			{
				ID = 1,
				Name = "Peeeeeeeteeeeeeeeer"
			};

			Assert.IsFalse(entity.IsValid());
		}

		[TestMethod]
		public void CheckValidationMessageTest()
		{
			var entity = new TestEntity()
			{
				ID = 1,
				Name = "Peeeeeeeteeeeeeeeer"
			};

			var validationMessages = entity.Validate();
			Assert.IsTrue(validationMessages
				.Select(x => x.ErrorMessage)
				.Contains("Name can't be this long"));
		}
	}
}
