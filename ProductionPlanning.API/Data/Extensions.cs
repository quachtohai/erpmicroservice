using Microsoft.EntityFrameworkCore;

namespace ProductionPlanning.API.Data
{
    public static class Extensions
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var dbContext = scope.ServiceProvider.GetRequiredService<ProductionPlanningContext>();
            dbContext.Database.MigrateAsync();

            return app;
        }
    }
}
