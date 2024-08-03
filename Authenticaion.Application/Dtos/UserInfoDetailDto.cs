using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record UserInfoDetailDto
        (Guid UserInfoId, Guid Id, string AccountCode, string AccountName, string Password, string FacultyDetail);
}
