namespace DotNet8.UnitOfWork.DbService.AppDbContextModels;

#region AggregatedCounter

public partial class AggregatedCounter
{
    public string Key { get; set; } = null!;

    public long Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}

#endregion
