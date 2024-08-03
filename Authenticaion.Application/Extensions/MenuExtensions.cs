using Authenticaion.Application.Dtos;
using Authentication.Domain.Models;

namespace Authenticaion.Application.Extensions
{
    public static class MenuExtensions
    {
        public static IEnumerable<MenuDto> ToMenuDtoList(this IEnumerable<Menu> menus)
        {
            return menus.Select(menu => new MenuDto(
               Id: menu.Id.Value,
               MenuCode: menu.MenuCode,
               Name: menu.Name,
                Description: menu.Description,
                Description2: menu.Description2,
                Description3: menu.Description3,
                Description4: menu.Description4,
                Description5: menu.Description5,
                Description6: menu.Description6


            ));
        }
    }
}
