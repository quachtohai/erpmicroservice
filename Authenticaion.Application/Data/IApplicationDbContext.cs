using Authentication.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Authenticaion.Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Menu> Menus { get; }
        DbSet<Module> Modules { get; }
        DbSet<Form> Forms { get; }
        DbSet<ActionInfo> ActionInfos { get; }
        DbSet<UserInfo> UserInfos { get; }
       
        DbSet<UserInfoDetail> UserInfoDetails { get; }
        DbSet<UserInfoMenu> UserInfoMenus { get; }
        DbSet<UserInfoAction> UserInfoActions { get; }
       

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
