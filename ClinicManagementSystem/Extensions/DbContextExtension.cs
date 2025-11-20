using ClinicManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagementSystem.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddDatabaseDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("Default")));
            return services;
        }
    }
}
