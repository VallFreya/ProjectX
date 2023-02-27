using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ProjectX.Application.Interfaces;
using ProjectX.Application.Services;
using ProjectX.Core.Repositories;
using ProjectX.Core.Repositories.Base;
using ProjectX.Infrastructure.Data;
using ProjectX.Infrastructure.Repositories;
using ProjectX.Infrastructure.Repositories.Base;
using ProjectX.Web.Interfaces;
using ProjectX.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DatabaseContext>(c =>
    c.UseSqlServer(builder.Configuration.GetConnectionString("Main") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Infrastruvture layer
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IMasterRepository, MasterRepository>();

// Application layer
builder.Services.AddScoped<IMasterService, MasterService>();

// Web layer
builder.Services.AddScoped<IMasterPageService, MasterPageService>();

var app = builder.Build();

// add seed data to database
using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    await DatabaseContextSeed.SeedAsync(service);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run(); 
