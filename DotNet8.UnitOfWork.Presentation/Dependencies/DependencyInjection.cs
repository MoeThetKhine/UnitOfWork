using DotNet8.UnitOfWork.DbService.AppDbContextModels;
using DotNet8.UnitOfWork.Presentation.Persistance;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.UnitOfWork.Presentation.Dependencies;

public static class DependencyInjection
{
	public static IServiceCollection AddDependencies(this IServiceCollection services)
	{
		services.AddDbContext<AppDbContext>(opt =>
		{
			opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
		});

		services.AddControllers().AddJsonOptions(opt =>
		{
			opt.JsonSerializerOptions.PropertyNamingPolicy = null;
		});

		services.AddScoped<IUnitOfWork, UnitOfWork>();

		return services;
	}
}
