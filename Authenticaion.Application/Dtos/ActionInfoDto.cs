using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record ActionInfoDto(
       Guid Id, string ActionCode, string Name, string ModuleCode, string FormCode,
            string Type, string TypeDetail, string Key, string Label,
           string FunctionName,           
            int? Order,           
           string Description,
           string Description2, string Description3, string Description4, string Description5,
           string Description6, bool Status);
}
