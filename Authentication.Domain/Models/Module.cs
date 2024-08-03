using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class Module : Entity<ModuleId>
    {
        public string ModuleCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;
        public string Entity { get; private set; } = default!;
        public string Type { get; private set; } = default!;
        public string EntitySearch { get; private set; } = default!;
        public string DisplayLabels { get; private set; } = default!;
        public string SeachFields { get; private set; } = default!;
        public string Title { get; private set; } = default!;
        public string DataIndex { get; private set; } = default!;
        public int? Order { get; private set; } = default!;  
        public string Panel_Title { get; private set; } = default!;
        public string Database_Title { get; private set; } = default!;
        public string AddNewEntity { get; private set; } = default!;
        public string EntityName { get; private set; } = default!;
        public string RecordEntityName { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Description2 { get; private set; } = default!;
        public string Description3 { get; private set; } = default!;
        public string Description4 { get; private set; } = default!;
        public string Description5 { get; private set; } = default!;
        public string Description6 { get; private set; } = default!;
        public bool Status { get; private set; } = default!;
        public static Module Create(ModuleId id, string moduleCode, string name,
            string entity, string type, string entitysearch, string displaylabels,
            string searchfields, string title, string dataindex, int? order,
            string panel_title,
            string database_title, string addNewEntity, string entityname, string recordentityname,
            string description,
            string description2, string description3, string description4, string description5,
            string description6, bool status
            )
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(moduleCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            var module = new Module
            {
                Id = id,
                ModuleCode = moduleCode,
                Name = name,
                Entity = entity,
                Type = type,
                EntitySearch = entitysearch,
                DisplayLabels = displaylabels,
                SeachFields = searchfields,
                Title = title,
                DataIndex = dataindex,
                Order = order,
                Panel_Title = panel_title,
                Database_Title = database_title,
                AddNewEntity = addNewEntity,
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
