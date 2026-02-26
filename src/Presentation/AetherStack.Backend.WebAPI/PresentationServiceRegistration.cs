using AetherStack.Backend.Application.Abstractions.Presentation;
using AetherStack.Backend.WebAPI.RequestContext;

namespace AetherStack.Backend.WebAPI
{
    public static class PresentationServiceRegistration
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRequestContext, HttpRequestContext>();

            return services;
        }
    }
}
