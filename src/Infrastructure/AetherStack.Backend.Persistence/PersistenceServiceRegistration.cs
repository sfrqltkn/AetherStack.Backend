using AetherStack.Backend.Application.Abstractions.Persistence.Repositories;
using AetherStack.Backend.Persistence.Interceptors;
using AetherStack.Backend.Persistence.Main;
using AetherStack.Backend.Persistence.Main.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AetherStack.Backend.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Database
            services.AddPostgreSql(configuration);

            // Identity
            services.AddIdentityConfiguration();

            // Interceptor
            services.AddScoped<AuditDomainEventInterceptor>();

            // Repositories
            services.AddScoped(typeof(IReadRepository<,>), typeof(EfReadRepository<,>));
            services.AddScoped(typeof(IWriteRepository<,>), typeof(EfWriteRepository<,>));

            // Unit Of Work
            services.AddScoped<IUnitOfWork, EfUnitOfWork>();

            return services;
        }
    }
}
