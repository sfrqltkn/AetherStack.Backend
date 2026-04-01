using AetherStack.Backend.Application.Abstractions.Infrastructure;
using AetherStack.Backend.Application.Abstractions.Infrastructure.Token;
using AetherStack.Backend.Infrastructure.Services.Identity;
using AetherStack.Backend.Infrastructure.Services.Token;
using AetherStack.Backend.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AetherStack.Backend.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //appsettings.json içindeki JwtSettings bölümünü JwtSettings sınıfına bağlar
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            return services;
        }
    }
}
