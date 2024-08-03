using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Dtos
{
    public record FormDto(
       Guid Id, string FormCode, string Name, string ModuleCode,
           string Entity, string Type, string TypeDetail, string EntitySearch, string DisplayLabels,
           string SearchFields, string RedirectLabel, string UrlRedirect, string Label,
           string FieldName, string[] Rule, string Span,
            int? Order,
            string EntityName, string RecordEntityname,
           string Description,
           string Description2, string Description3, string Description4, string Description5,
           string Description6, bool Status);
}
