using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record UserLoginDto(
        string UserName, string Password,  string Key, string Issuer, string Audience,
        string TokenString
        );
}
