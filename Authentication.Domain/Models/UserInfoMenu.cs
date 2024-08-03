using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class UserInfoMenu : Entity<UserInfoMenuId>
    {
        
        public UserInfoId UserInfoId { get; set; } = default!;        
        public MenuId MenuId { get; private set; } = default!;
        public string MenuCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;

        public UserInfoMenu(UserInfoId userInfoId, MenuId menuId, string menuCode, string name)
        {
            Id = UserInfoMenuId.Of(Guid.NewGuid());
            UserInfoId = userInfoId;
            MenuId = menuId;
            MenuCode = menuCode;
            Name = name;
        }
    }
}
