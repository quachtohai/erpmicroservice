using Authentication.Domain.ValueObjects;

namespace Authenticaion.Application.Dtos
{
    public record ModuleDto(
        Guid Id, string ModuleCode, string Name,
            string Entity, string Type, string EntitySearch, string DisplayLabels,
            string SearchFields, string Title, string DataIndex, int? Order,
            string Panel_Title,
            string Database_Title, string AddNewEntity, string EntityName, string RecordEntityname,
            string Description,
            string Description2, string Description3, string Description4, string Description5,
            string Description6, bool Status);


}
