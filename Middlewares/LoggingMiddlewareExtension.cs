using Microsoft.AspNetCore.Builder;

namespace custom_middleware_logging_example.Middlewares
{
public static class LoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }    
}