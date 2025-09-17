using https_Codefirst.Models;
using Microsoft.EntityFrameworkCore;

namespace https_Codefirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<UserDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("mycon")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Append("Content-Security-Policy", "default-src 'self';script-src 'self'https://trusted.com;");
                await  next();
            });
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
