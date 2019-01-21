using ProductService.BusinessLayer;
using ProductService.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.DataLayer
{
	public abstract class Repository<T> : IRepository<T> where T : Entity
	{
		protected ProductServiceContext context;

		protected Repository(ProductServiceContext context)
		{
			this.context = context;
		}

		/// <summary>
		/// This function will persist an entity to the database.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public async Task<T> Add(T entity)
		{
			if (!entity.IsValid())
				throw new ArgumentException(string.Format("Instance of {0} is not valid", typeof(T)));

			await context.AddAsync<T>(entity);
			await context.SaveChangesAsync();

			return entity;
		}

		/// <summary>
		/// A generic function for deleting entities from the database.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public async Task<bool> Delete(T entity)
		{
			if (entity == null)
				throw new ArgumentNullException(nameof(entity));

			context.Remove(entity);
			var changes = await context.SaveChangesAsync();

			// Only one item should have been affected.
			return changes == 1;
		}

		/// <summary>
		/// A generic function to obtain all records from a certain type from the database.
		/// </summary>
		/// <returns></returns>
		public async Task<IList<T>> GetAll()
		{
			return await context.Set<T>()
						.ToAsyncEnumerable()
						.ToList();
		}

		/// <summary>
		/// A generic function to update the specified entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public async Task<T> Update(T entity)
		{
			if (!entity.IsValid())
				throw new ArgumentException(string.Format("Instance of {0} is not valid", typeof(T)));

			context.Update(entity);
			await context.SaveChangesAsync();

			return entity;
		}
	}
}
