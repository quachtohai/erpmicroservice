using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoMenusById
{
    public record GetUserInfoMenusByIdQuery(Guid UserInfoId)
    : IQuery<GetUserInfoMenusByIdResult>;

    public record GetUserInfoMenusByIdResult(UserInfoDto Results);
}
