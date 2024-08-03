using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoActionsById
{
    public record GetUserInfoActionsByIdQuery(Guid UserInfoId)
    : IQuery<GetUserInfoActionsByIdResult>;

    public record GetUserInfoActionsByIdResult(UserInfoDto Results);
}
