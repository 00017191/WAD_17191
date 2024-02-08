using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WAD_17191.Application
{
	public static class Configuration
	{
		public static IServiceCollection ApplicationService(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
			});

			return services;
		}
	}
}
