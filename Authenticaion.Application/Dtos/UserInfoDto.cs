using Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record UserInfoDto
    (
        Guid Id,
        string UserInfoCode,
        string FirstName,
        string LastName,
        string FullName,
        DateTime? BirthDate,
        string Year,
        List<UserInfoDetailDto> UserInfoDetails,
        List<UserInfoMenuDto> UserInfoMenus,
        List<UserInfoActionDto> UserInfoActions,
        string Message,
        bool Success
        );
}
