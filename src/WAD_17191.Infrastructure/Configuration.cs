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
		public static IServiceCollection AddInfrastructureServices(
			this IServiceCollection services,
			IConfiguration configuration
		)
		{
			services.AddDbContext<ApplicationDbContext>(
				options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
			);

			services.AddScoped<IUserRepo, UserRepository>();
			services.AddScoped<IActivityRepo, ActivityRepository>();


			return services;
		}
	}
}
