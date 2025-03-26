namespace DotNet8.UnitOfWork.Presentation.Persistance;

public interface IRepositoryBase<T> where T : class
{
	IQueryable<T> Query(Expression<Func<T, bool>>? expression = null);
	Task AddAsync(T entity, CancellationToken cs = default);
	void Add(T entity);

}
