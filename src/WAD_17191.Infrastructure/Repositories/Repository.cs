using Microsoft.EntityFrameworkCore;
using WAD_17191.Infrastructure.AppData;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Infrastructure.Repositories
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private readonly ApplicationDbContext _context;

		public Repository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<TEntity>> GetAllAsync()
		{
			return await _context.Set<TEntity>().ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public async Task CreateAsync(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(TEntity entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var entity = await _context.Set<TEntity>().FindAsync(id);
			if (entity != null)
			{
				_context.Set<TEntity>().Remove(entity);
				await _context.SaveChangesAsync();
			}
		}

		// Used for implementing include statment 
		public IQueryable<TEntity> GetAll()
		{
			return _context.Set<TEntity>().AsQueryable();
		}
	}
}
