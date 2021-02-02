using Float.Api.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Float.Api.Extensions
{
    public static class AppExtension
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Float.Api v1"));
        }
        public static void UseExceptionMiddleWare(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
