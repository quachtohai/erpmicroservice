
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace Authentication.Infrastructure.Data.Extensions
{
    public static class DatabaseExtentions
    {
        public static async Task InitialiseDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.MigrateAsync().GetAwaiter().GetResult();

            await SeedAsync(context);
        }

        private static async Task SeedAsync(ApplicationDbContext context)
        {
            await SeedDataAsync(context);
            
        }
        private static async Task SeedDataAsync(ApplicationDbContext context)
        {
            if (!await context.Menus.AnyAsync())
            {
                await context.Menus.AddRangeAsync(InitialData.Menus);
                
                await context.SaveChangesAsync();
            }
            if(!await context.Modules.AnyAsync()) {
                await context.Modules.AddRangeAsync(InitialData.Forms);
                await context.SaveChangesAsync();
            }
            if (!await context.Forms.AnyAsync())
            {
                await context.Forms.AddRangeAsync(InitialData.FormsDetails);
                await context.SaveChangesAsync();
            }
            if (!await context.ActionInfos.AnyAsync())
            {
                await context.ActionInfos.AddRangeAsync(InitialData.ActionInfos);
                await context.SaveChangesAsync();
            }
        }
    }
}
