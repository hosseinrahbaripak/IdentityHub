using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrustructure.Configuration
{
    public static class PersistanceConfigurationRegistration
    {
        public static IServiceCollection ConfigurationRegistration(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<IdentityHubContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:IdentityHubConnection"]));

            return services;
        }
    }
}
