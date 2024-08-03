using Authenticaion.Application.Dtos;
using Authentication.Domain.Models;

namespace Authenticaion.Application.Extensions
{
    public static class ModuleExtensions
    {
        public static IEnumerable<ModuleDto> ToModuleDtoList(this IEnumerable<Module> modules)
        {
            return modules.Select(module => new ModuleDto(
                Id: module.Id.Value,
                ModuleCode: module.ModuleCode,
                Name: module.Name,
                Entity: module.Entity,
                Type: module.Type,
                EntitySearch: module.EntitySearch,
                DisplayLabels: module.DisplayLabels,
                SearchFields: module.SeachFields,
                Title: module.Title,
                DataIndex: module.DataIndex,
                Order: module.Order,
                Panel_Title: module.Panel_Title,
                Database_Title: module.Database_Title,
                AddNewEntity: module.AddNewEntity,
                EntityName: module.EntityName,
                RecordEntityname: module.RecordEntityName,
                Description: module.Description,
                Description2: module.Description2,
                Description3: module.Description3,
                Description4: module.Description4,
                Description5: module.Description5,
                Description6: module.Description6,
                Status: module.Status
            ));
        }
    }
}
