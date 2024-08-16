using Microsoft.EntityFrameworkCore;

namespace ReportingService.Datas
{
    public static class Extentions
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var dbContext = scope.ServiceProvider.GetRequiredService<ReportingContext>();
            dbContext.Database.MigrateAsync();

            return app;
        }
    }
}
