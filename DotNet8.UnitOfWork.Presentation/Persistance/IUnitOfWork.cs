﻿namespace DotNet8.UnitOfWork.Presentation.Persistance;

public interface IUnitOfWork
{
	IBlogRepository BlogRepository { get; }
}
