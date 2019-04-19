using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace grape
{
    public static class Bootstrapper
    {

        public static void Bootstrap(IServiceCollection services, IConfiguration configuration)
        {
            services.Scan(scan => scan
            .FromCallingAssembly()

            .AddClasses(c => c.Where(t => t.Name.EndsWith("Handler")))
            .AsImplementedInterfaces()
            .WithTransientLifetime()
            );
        }

    }
}
