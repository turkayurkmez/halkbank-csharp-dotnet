using eshop.DataAccess;
using eshop.DataAccess.DataContext;
using eshop.Services;
using Microsoft.EntityFrameworkCore;

namespace eshop.MVC.Extensions
{

    //PS: Aşağıdaki extension sınıfı; eshop.Extensions kütüphanesine taşıdık.
    //public static class IoCExtensions
    //{
    //    public static void AddIoCRequirements(this IServiceCollection services, string connectionString)
    //    {
    //        services.AddScoped<IProductService, ProductService>();
    //        services.AddScoped<IProductRepository, EFProductRepository>();
    //        services.AddScoped<ICategoryService, CategoryService>();
    //        services.AddScoped<ICategoryRepository, EFCategoryRepository>();
    //        services.AddScoped<IUserService, UserService>();

    //        services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));
    //    }
    //}
}
