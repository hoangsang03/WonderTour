using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WonderTour.Data;

namespace DataAccessLibrary
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<WonderTourDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(Constant.WonderTourDbConnectionName)));

            return services;
        }
    }
}
