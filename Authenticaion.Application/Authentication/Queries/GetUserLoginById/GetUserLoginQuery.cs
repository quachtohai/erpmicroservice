using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserLogin
{
    public record GetUserLoginQuery(UserLoginDto UserInfo)
   : IQuery<GetUserLoginResult>;

    public record GetUserLoginResult(UserLoginDto Results);
}
