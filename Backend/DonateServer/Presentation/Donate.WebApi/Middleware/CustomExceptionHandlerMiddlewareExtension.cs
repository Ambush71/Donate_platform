namespace Donate.WebApi.Middleware;

public static class CustomExceptionMiddlewareExtension
{
    public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomExceptionMiddlewareHandler>();
    }
}