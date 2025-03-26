namespace DotNet8.UnitOfWork.Presentation.Persistance;

#region RepositoryBase

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
	internal readonly AppDbContext _context;
	internal DbSet<T> _dbSet;

	public RepositoryBase(AppDbContext context)
	{
		_context = context;
		_dbSet = context.Set<T>();
	}

	public void Add(T entity)
	{
		_dbSet.Add(entity);
	}

	public async Task AddAsync(T entity, CancellationToken cs = default)
	{
		await _dbSet.AddAsync(entity, cs);
	}

	public void AddRange(IEnumerable<T> entities)
	{
		_dbSet.AddRange(entities);
	}

	public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cs)
	{
		await _dbSet.AddRangeAsync(entities, cs);
	}

	public void Delete(T entity)
	{
		_dbSet.Remove(entity);
	}

	public void DeleteRange(IEnumerable<T> entities)
	{
		_dbSet.RemoveRange(entities);
	}

	public void Dispose()
	{
		_context.Dispose();
	}
}

#endregion