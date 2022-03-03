using Microsoft.Extensions.DependencyInjection;
using MoviesCollection.EFPersistence.Repositories;

namespace MoviesCollection.Infra.Ioc.ApplicationScopeExtensions
{
    public static class RepositoryScopeExtension
    {
        public static void RegisterRepositoriesDependencies(this IServiceCollection service)
        {
            service.AddScoped<ActorRepository>();
            service.AddScoped<MovieRepository>();
        }
    }
}
