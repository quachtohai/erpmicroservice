using Authenticaion.Application.Data;
using Authentication.Domain.Models;
using System.Reflection;

namespace Authentication.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<Form> Forms => Set<Form>();
        public DbSet<ActionInfo> ActionInfos => Set<ActionInfo>();
        public DbSet<Authentication.Domain.Models.Module> Modules => 
            Set<Authentication.Domain.Models.Module>();
        
        public DbSet<UserInfo> UserInfos => Set<UserInfo>();
        public DbSet<UserInfoDetail> UserInfoDetails => Set<UserInfoDetail>();

        public DbSet<UserInfoMenu> UserInfoMenus => Set<UserInfoMenu>();

        public DbSet<UserInfoAction> UserInfoActions => Set<UserInfoAction>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
