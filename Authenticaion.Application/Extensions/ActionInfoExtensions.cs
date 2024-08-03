using Authentication.Domain.Models;



namespace Authenticaion.Application.Extensions
{
    public static class ActionInfoExtensions
    {
        public static IEnumerable<ActionInfoDto> ToActionInfoDtoList(this IEnumerable<ActionInfo> actioninfos)
        {
            return actioninfos.Select(action => new ActionInfoDto(
               Id: action.Id.Value,
               ActionCode: action.ActionCode,
               Name: action.Name,
               ModuleCode: action.ModuleCode,
               FormCode: action.FormCode,
               Type: action.Type,
               TypeDetail: action.TypeDetail,
               Key: action.Key,
               Label: action.Label,
               FunctionName: action.FunctionName,
               Order: action.Order,

                Description: action.Description,
                Description2: action.Description2,
                Description3: action.Description3,
                Description4: action.Description4,
                Description5: action.Description5,
                Description6: action.Description6,
                Status: action.Status


            ));
        }
    }
}
