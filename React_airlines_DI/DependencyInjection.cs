using Microsoft.Extensions.DependencyInjection;
using React_airlines_EFCore.Repositories;
using React_airlines_Service;
using React_airlines_ServiceInterface;
using React_airlines_RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using React_airlines_EFCore.AppDbContext;

namespace React_airlines_DI
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}