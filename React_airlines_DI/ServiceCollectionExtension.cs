using Microsoft.Extensions.DependencyInjection;
using React_airlines_Core.Interfaces.Services;
using System.Reflection;


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
