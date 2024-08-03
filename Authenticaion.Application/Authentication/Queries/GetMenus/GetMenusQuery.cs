using Authenticaion.Application.Dtos;
using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;

namespace Authenticaion.Application.Authentication.Queries.GetMenus
{
    public record GetMenusQuery(PaginationRequest PaginationRequest)
    : IQuery<GetMenusResult>;

    public record GetMenusResult(PaginatedResult<MenuDto> Menus);
}
