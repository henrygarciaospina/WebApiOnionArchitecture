using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.Services;
using OnionArchitecture.Core.Services.Contracts;

namespace OnionArchitecture.Api.Services.Configuration
{
    public static class ConfigureServices
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateAssignmentService, CreateAssignmentService>();
            services.AddScoped<IUpdateAssignmentService, UpdateAssigmentService>();
        }
    }
}
