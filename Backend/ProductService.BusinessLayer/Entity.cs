using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProductService.BusinessLayer
{
	public abstract class Entity
	{
		/// <summary>
		/// This function will validate a Entity based on it's dataannotations.
		/// </summary>
		/// <returns></returns>
		public IList<ValidationResult> Validate()
		{
			// Create the context
			var validationContext = new ValidationContext(this);

			// Create a list where the results will be sotred in.
			var validationsResults = new List<ValidationResult>();

			// Validate the entity.
			bool correct = Validator.TryValidateObject(this, validationContext, validationsResults, true);

			// Return the list of validation results.
			return validationsResults;
		}

		/// <summary>
		/// An entity is valid if its validation function doesn't return any results.
		/// </summary>
		/// <returns></returns>
		public bool IsValid()
		{
			return !this.Validate().Any();
		}
	}
}
