using Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Extensions
{
    public static class FormExtensions
    {
        public static IEnumerable<FormDto> ToFormDtoList(this IEnumerable<Form> forms)
        {
            return forms.Select(form => new FormDto(
                Id: form.Id.Value,
                FormCode: form.FormCode,
                Name: form.Name,
                ModuleCode: form.ModuleCode,                
                Entity: form.Entity,
                Type: form.Type,
                TypeDetail: form.TypeDetail,
                EntitySearch: form.EntitySearch,
                DisplayLabels: form.DisplayLabels,
                SearchFields: form.SeachFields,
                RedirectLabel: form.RedirectLabel,
                UrlRedirect: form.UrlRedirect,
                Label: form.Label,
                FieldName: form.FieldName,
                Rule: form.Rule,
                Span:form.Span,
                Order: form.Order,                     
                EntityName: form.EntityName,
                RecordEntityname: form.RecordEntityName,
                Description: form.Description,
                Description2: form.Description2,
                Description3: form.Description3,
                Description4: form.Description4,
                Description5: form.Description5,
                Description6: form.Description6,
                Status: form.Status
            ));
        }
    }
}
