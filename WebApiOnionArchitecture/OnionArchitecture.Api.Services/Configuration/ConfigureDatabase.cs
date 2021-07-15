using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Infrastructure.Repositories;

namespace OnionArchitecture.Api.Services.Configuration
{
    public static class ConfigureDatabase
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<OnionArchitectureContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("OnionArchitecture")));
    }
}
