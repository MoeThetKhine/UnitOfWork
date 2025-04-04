﻿namespace DotNet8.UnitOfWork.Presentation;

#region UnitOfWork

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

#endregion