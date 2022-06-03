using Microsoft.Extensions.DependencyInjection;
using ProjectEditor.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjectEditor.Application.Bootstrap
{
    public static class ServiceBuilderExtension
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.Scan(scan => scan
                    .FromAssemblies(Assembly.GetExecutingAssembly())
                    .AddClasses(c => c.WithAttribute<MapServiceDependencyAttribute>())        // Registriert alle Klassen die das Attribut tragen
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());
        }
    }
}
