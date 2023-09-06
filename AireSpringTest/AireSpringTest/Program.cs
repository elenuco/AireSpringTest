using AireSpringTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
/**Add  the program.cs configuration. Configure appsettings.Development.json*/
builder.Configuration.AddJsonFile("appsettings.Development.json");
//**Configure the DbContest for connect to the database*/
builder.Services.AddDbContext<EmpleadosDbContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    ;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
