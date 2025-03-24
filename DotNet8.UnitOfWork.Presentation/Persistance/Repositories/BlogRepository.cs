﻿using DotNet8.UnitOfWork.DbService.AppDbContextModels;

namespace DotNet8.UnitOfWork.Presentation.Persistance.Repositories
{
	public class BlogRepository : RepositoryBase<TblBlog>, IBlogRepository
	{
		public BlogRepository(AppDbContext context)
			: base(context) { }
	}

}
