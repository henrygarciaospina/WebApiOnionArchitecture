using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.Repositories.Contracts;
using OnionArchitecture.Infrastructure.Repositories;

namespace OnionArchitecture.Api.Services.Configuration
{
    public static class ConfigureRepositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAssignmentsRepository, AssignmentsRepository>();
        }
    }
}
