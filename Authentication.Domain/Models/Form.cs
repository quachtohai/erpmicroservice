using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class Form :Entity<FormId>
    {
        public string FormCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;
        public string ModuleCode { get; private set; } = default!;
        public string Entity { get; private set; } = default!;
        public string Type { get; private set; } = default!;
        public string TypeDetail { get; private set; } = default!;
        public string EntitySearch { get; private set; } = default!;
        public string DisplayLabels { get; private set; } = default!;
        public string SeachFields { get; private set; } = default!;
        public string RedirectLabel { get; private set; } = default!;
        public string UrlRedirect { get; private set; } = default!;
        public string Label { get; private set; } = default!;
        public string FieldName { get; private set; } = default!;
        public string[] Rule { get; private set; } = default!;
        public string Span { get; private set; } = default!;
        
        public int? Order { get; private set; } = default!;        
        public string EntityName { get; private set; } = default!;
        public string RecordEntityName { get; private set; } = default!;

        public string Description { get; private set; } = default!;
        public string Description2 { get; private set; } = default!;
        public string Description3 { get; private set; } = default!;
        public string Description4 { get; private set; } = default!;
        public string Description5 { get; private set; } = default!;
        public string Description6 { get; private set; } = default!;
        public bool Status { get; private set; } = default!;
        public static Form Create(FormId id, string formCode,
             string name, string moduleCode,
            string entity, string type, string typeDetail,
            string entitysearch, string displaylabels,
            string searchfields, string redirectlabel, string urlredirect,  string label,
            string fieldName, string[] rule, string span,
            int? order,
            string entityname, string recordentityname,
            string description,
            string description2, string description3, string description4, string description5,
            string description6, bool status
            )
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(moduleCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(formCode);

            var module = new Form
            {
                Id = id,
                FormCode = formCode,
                Name = name,
                ModuleCode = moduleCode,
                Entity = entity,
                Type = type,
                TypeDetail = typeDetail,
                EntitySearch = entitysearch,
                DisplayLabels = displaylabels,
                SeachFields = searchfields,
                RedirectLabel = redirectlabel,
                UrlRedirect = urlredirect,
                Label = label,
                FieldName = fieldName,
                Rule = rule,
                Span = span,
                Order   = order,
                EntityName = entityname,
                RecordEntityName = recordentityname,
                Description = description,
                Description2 = description2,
                Description3 = description3,
                Description4 = description4,
                Description5 = description5,
                Description6 = description6,
                Status = status
            };

            return module;
        }
    }
}
