using MovieDB.domain.Entities;
using MovieDB.domain.Interfaces;
using MovieDB.domain.Services;
using MovieDB.infra.Context;
using MovieDB.infra.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<MovieService>();
builder.Services.AddScoped<ActorService>();
builder.Services.AddScoped<DirectorService>();  

builder.Services.AddScoped<MyDBContext>();
builder.Services.AddScoped(typeof(IGenericRepository<Movie>), typeof(MovieRepository));
builder.Services.AddScoped(typeof(IGenericRepository<Actor>), typeof(ActorRepository));
builder.Services.AddScoped(typeof(IGenericRepository<Director>), typeof(DirectorRepository));
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
