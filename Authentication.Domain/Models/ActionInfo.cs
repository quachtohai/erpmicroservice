using Authentication.Domain.Abstractions;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Models
{
    public class ActionInfo : Entity<ActionInfoId>
    {
        public string ActionCode { get; private set; } = default!;
        public string Name { get; private set; } = default!;
        public string ModuleCode { get; private set; } = default!;
        public string FormCode { get; private set; } = default!;

        public string Type { get; private set; } = default!;
        public string TypeDetail { get; private set; } = default!;
        public string Key { get; private set; } = default!;
        public string Label { get; private set; } = default!;
        public string FunctionName { get; private set; } = default!;
        public int? Order { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Description2 { get; private set; } = default!;
        public string Description3 { get; private set; } = default!;
        public string Description4 { get; private set; } = default!;
        public string Description5 { get; private set; } = default!;
        public string Description6 { get; private set; } = default!;
        public bool Status { get; private set; } = default!;

        public static ActionInfo Create(ActionInfoId id,
            string actionCode, string name, string moduleCode, string formCode, string type, string typeDetail, string key, string label, string functionName, int? order, string description, string description2, string description3, string description4, string description5, string description6, bool status)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(actionCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            var action = new ActionInfo()
            {
                Id = id,
                ActionCode = actionCode,
                Name = name,
                ModuleCode = moduleCode,
                FormCode = formCode,
                Type = type,
                TypeDetail = typeDetail,
                Key = key,
                Label = label,
                FunctionName = functionName,
                Order = order,
                Description = description,
                Description2 = description2,
                Description3 = description3,
                Description4 = description4,
                Description5 = description5,
                Description6 = description6,
                Status = status,
            };
            return action;


        }
    }
}
