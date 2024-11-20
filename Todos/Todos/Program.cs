using Microsoft.AspNetCore.Builder;

namespace Todos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");        
            app.MapGet("/ping", () => "pong");
            app.MapControllerRoute("default",
                "{controller=Todo}/{action=Create}/{id?}");
            
            app.Run();
        }
    }
}
