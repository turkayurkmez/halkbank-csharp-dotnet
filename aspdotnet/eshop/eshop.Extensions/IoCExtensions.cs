using eshop.DataAccess;
using eshop.DataAccess.DataContext;
using eshop.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace eshop.MVC.Extensions
{
    public static class IoCExtensions
    {
        public static void AddIoCRequirements(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));
        }
    }
}
