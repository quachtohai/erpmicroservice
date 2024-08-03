using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record UserInfoActionDto
  (Guid UserInfoId, Guid Id, string ActionCode, string ModuleCode, string Name);
}
