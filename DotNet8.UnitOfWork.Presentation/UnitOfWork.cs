using DotNet8.UnitOfWork.DbService.AppDbContextModels;
using DotNet8.UnitOfWork.Presentation.Persistance.Repositories;
using DotNet8.UnitOfWork.Presentation.Persistance;

namespace DotNet8.UnitOfWork.Presentation
{
	public class UnitOfWork : IUnitOfWork
	{
		public readonly AppDbContext _context;
		public IBlogRepository BlogRepository { get; set; }

		#region UnitOfWork

		public UnitOfWork(AppDbContext context)
		{
			_context = context;
			BlogRepository ??= new BlogRepository(context);
		}

		#endregion

	}

}
