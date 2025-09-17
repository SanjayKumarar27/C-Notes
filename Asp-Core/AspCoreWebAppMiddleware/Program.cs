using AspCoreWebAppMiddleware.Middlewares;

namespace AspCoreWebAppMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.Use(async (context, next) =>
            {
                app.Logger.LogInformation("1");
                //await next(context); or 
                context.Response.Headers.Append("Key","KPMG");
                await next.Invoke(context);
                app.Logger.LogInformation("11");
            });

            app.Use(async (context, next) =>
            {
                app.Logger.LogInformation("2");
                context.Response.Headers.Append("Language", "C#");
                //await next(context); or 
                await next.Invoke(context);
                app.Logger.LogInformation("22");
            });

            //app.UseMiddleware<MyMiddlewareClass>();
            app.UseMyMiddleware();

            //app.Run(async c=> await c.Response.WriteAsync("Not Welcome"));


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
