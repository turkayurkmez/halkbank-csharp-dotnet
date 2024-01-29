var builder = WebApplication.CreateBuilder(args);
//Convention over Configuration
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute("default", "{controller=Main}/{action=Index}/{id?}");


//app.MapGet("/", () => "Hello World!");

app.Run();
