
namespace AspCoreWebAppMiddleware.Middlewares
{
    public class MyMiddlewareClass
    {
        RequestDelegate _next;//private variable with _
        ILogger<MyMiddlewareClass> _logger;


        public MyMiddlewareClass(RequestDelegate next, ILogger<MyMiddlewareClass> logger)//Dependecy Injection
        {
            _next = next;
            _logger = logger;
        }

        //Sync
        //public void Invoke(HttpContext context)
        //{
        //    _next(context);
        //}\

        //Async
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"MyMiddleware Req {DateTime.Now.ToString("HH:MM:ss:FFFF")}");
            await _next(context);
            _logger.LogInformation($" My Middleware Res {DateTime.Now.ToString("HH:MM:ss:FFFF")}");
        }
    }
    public static class MyExtention
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<MyMiddlewareClass>();
        }
    }

    
}

