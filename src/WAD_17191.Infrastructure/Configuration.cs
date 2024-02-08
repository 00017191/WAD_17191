using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WAD_17191.Application.Interfaces;
using WAD_17191.Infrastructure.AppData;
using WAD_17191.Infrastructure.Repositories;

namespace WAD_17191.Infrastructure
{
	public static class Configuration
	{
		public static IServiceCollection InfrastructureService(this IServiceCollection services, IConfiguration configuration)
		{
			//Connection to database
			services.AddDbContext<ApplicationDbContext>(
				options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
			);
			// Registering Dependency Injection
			services.AddTransient<IUserRepo, UserRepository>();
			services.AddTransient<IActivityRepo, ActivityRepository>();
			return services;
		}
	}
}
