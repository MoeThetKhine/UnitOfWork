﻿namespace DotNet8.UnitOfWork.DbService.AppDbContextModels;

public partial class Server
{
    public string Id { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime LastHeartbeat { get; set; }
}
