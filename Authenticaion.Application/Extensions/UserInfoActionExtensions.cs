using Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Extensions
{
    public static class UserInfoActionExtensions
    {
        public static IEnumerable<UserInfoDto> ToUserActionInfoDtoList(this IEnumerable<UserInfo> userinfos)
        {
            return userinfos.Select(userinfo => new UserInfoDto(
                Id: userinfo.Id.Value,
                UserInfoCode: userinfo.UserInfoCode,
                FirstName: userinfo.FirstName,
                LastName: userinfo.LastName,
                FullName: userinfo.FullName,
                BirthDate: userinfo.BirthDate,
                Year: userinfo.Year,
                 UserInfoDetails: userinfo.Items.Select
                 (i => new UserInfoDetailDto(userinfo.Id.Value, i.Id.Value, i.AccountCode, i.AccountName, i.Password, i.FacultyDetail)).ToList(),
                UserInfoMenus: userinfo.ItemMenus.Select(i => new UserInfoMenuDto
                (userinfo.Id.Value, i.Id.Value, i.MenuCode, i.Name)).ToList(),
                UserInfoActions: userinfo.ItemActions.Select(i => new UserInfoActionDto
                (userinfo.Id.Value, i.Id.Value, i.ActionCode, i.ModuleCode, i.Name)).ToList(),
                Message: "Query OK",
                Success: true
            ));
        }
    }
}
