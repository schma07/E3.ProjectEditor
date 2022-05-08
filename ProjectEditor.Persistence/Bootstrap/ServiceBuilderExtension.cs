using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectEditor.Persistence.Bootstrap
{
    public static class ServiceBuilderExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.Scan(scan => scan
                    .FromAssemblies(Assembly.GetExecutingAssembly())
                    .AddClasses(c => c.WithAttribute<MapServiceDependencyAttribute>())        // Registriert alle Klassen die das Attribut tragen
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());

        }
    }
}
