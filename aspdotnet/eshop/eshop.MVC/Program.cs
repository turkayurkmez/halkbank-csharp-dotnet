
using eshop.Extensions;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IProductRepository, EFProductRepository>();
//builder.Services.AddScoped<ICategoryService, CategoryService>();
//builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();
//builder.Services.AddScoped<IUserService, UserService>();

var connectionString = builder.Configuration.GetConnectionString("db");
//builder.Services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddIoCRequirements(connectionString);



//.net core' session varsayılan olarak disabled durumdadır. 
// HttpContext üzerinden erişilebilmesi için:
builder.Services.AddSession();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/Account/Login";
                    option.ReturnUrlParameter = "gidilecekSayfa";
                    option.AccessDeniedPath = "/Account/ErisimEngellendi";
                });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
