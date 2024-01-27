namespace WAD_17191.Application.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> GetAll();

		Task<List<TEntity>> GetAllAsync();
		Task<TEntity> GetByIdAsync(int id);
		Task CreateAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task DeleteAsync(int id);
	}
}
