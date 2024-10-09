using CRUDNet7MVC.Datos;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Configuramos la conexion a sql ser local db MSSQLLOCAL
        builder.Services.AddDbContext<AplicationDbContex>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

        // Add services to the container.
        builder.Services.AddControllersWithViews();

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
            pattern: "{controller=Inicio}/{action=Index}/{id?}");

        app.Run();
    }
}