using AM.applicationCore.Interfaces;
using AM.applicationCore.Services;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using AM.UI.Console;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IserviceFlight, ServiceFlight>();
builder.Services.AddScoped<IServicePlane, ServicePlan>();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddDbContext<DbContext,AmContext>();
builder.Services.AddSingleton<Type>(T=>typeof(GenericRepository<>));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
