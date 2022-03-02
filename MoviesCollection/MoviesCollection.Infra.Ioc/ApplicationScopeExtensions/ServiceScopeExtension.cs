using Microsoft.Extensions.DependencyInjection;
using MoviesCollection.BusinessApp.Maintenance;

namespace MoviesCollection.Infra.Ioc.ApplicationScopeExtensions
{
    public static class ServiceScopeExtension
    {

        public static void RegisterServiceDependencies(this IServiceCollection service)
        {
            service.AddScoped<ActorMaintenanceService>();
        }

    }
}
