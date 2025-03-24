namespace DotNet8.UnitOfWork.Presentation.Persistance
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		internal readonly AppDbContext _context;
		internal DbSet<T> _dbSet;

		public RepositoryBase(AppDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}
	}
}
