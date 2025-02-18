using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data
{
    public static class Extention
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<DiscountContext>();
            context.Database.MigrateAsync();
            return app;
        }
    }
}
