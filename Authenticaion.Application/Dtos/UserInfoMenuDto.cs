using Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{

    public record UserInfoMenuDto
   (Guid UserInfoId, Guid Id, string MenuCode, string Name);
}
