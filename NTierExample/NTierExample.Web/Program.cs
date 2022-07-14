using Microsoft.EntityFrameworkCore;
using NTierExample.BLL.Services.Abstract;
using NTierExample.BLL.Services.Implementation;
using NTierExample.Dll.Context;
using NTierExample.Dll.Repositories.Abstract;
using NTierExample.Dll.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("NTierExampleContext")));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ILogRepository), typeof(LogRepository));
builder.Services.AddScoped(typeof(IActivityRepository), typeof(ActivityRepository));

builder.Services.AddTransient<ILogService, LogService>();
builder.Services.AddTransient<IActivityService, ActivityService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
