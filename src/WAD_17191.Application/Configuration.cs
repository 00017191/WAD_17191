using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WAD_17191.Application
{
	public static class Configuration
	{
		public static IServiceCollection ApplicationService(this IServiceCollection services)
		{
			// Using auto mapper for mapping core model to my DTO model
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			// Configuring mediatr
			services.AddMediatR(config =>
			{
				config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
			});

			return services;
		}
	}
}
