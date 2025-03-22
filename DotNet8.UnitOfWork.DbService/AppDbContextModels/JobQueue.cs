﻿namespace DotNet8.UnitOfWork.DbService.AppDbContextModels;

#region JobQueue

public partial class JobQueue
{
    public long Id { get; set; }

    public long JobId { get; set; }

    public string Queue { get; set; } = null!;

    public DateTime? FetchedAt { get; set; }
}

#endregion