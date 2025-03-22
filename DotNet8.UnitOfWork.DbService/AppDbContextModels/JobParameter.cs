namespace DotNet8.UnitOfWork.DbService.AppDbContextModels;

#region JobParameter

public partial class JobParameter
{
    public long JobId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Job Job { get; set; } = null!;
}

#endregion