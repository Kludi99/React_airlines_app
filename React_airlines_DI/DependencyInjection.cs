using Microsoft.Extensions.DependencyInjection;
using React_airlines_EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using React_airlines_EFCore.AppDbContext;
using System.Reflection;
using React_airlines_EFCore.Interfaces.Repositories;
using React_airlines_Core.Common;


namespace React_airlines_DI
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddServicesFromAssembly(typeof(GenericService).Assembly);
        }
    }
}