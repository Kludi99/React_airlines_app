using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System;
using React_airlines_ServiceInterface;
using React_airlines_Service;

namespace React_airlines_DI
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServicesFromAssembly(this IServiceCollection services, Assembly assembly)
        {
            var serviceTypes = assembly.GetTypes()
                .Where(type => typeof(IGenericService).IsAssignableFrom(type) && !type.IsAbstract);

            foreach (var serviceType in serviceTypes)
            {
                var implementedInterfaces = serviceType.GetInterfaces()
                    .Where(i => typeof(IGenericService).IsAssignableFrom(i));

                foreach (var implementedInterface in implementedInterfaces)
                {
                    if (implementedInterface != serviceType)
                    {
                        services.Add(new ServiceDescriptor(implementedInterface, serviceType, ServiceLifetime.Transient));
                    }
                }
            }

            return services;
        }
    }
}
