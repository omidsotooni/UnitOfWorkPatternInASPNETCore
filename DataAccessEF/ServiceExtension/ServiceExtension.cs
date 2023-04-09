using DataAccessEF.MyDBContext;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccessEF.TypeRepositories;

namespace DataAccessEF.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServerConStr"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
