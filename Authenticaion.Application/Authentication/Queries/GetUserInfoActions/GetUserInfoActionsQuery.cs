using BuildingBlocks.Pagination;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoActions
{
    public record GetUserInfoActionsQuery(PaginationRequest PaginationRequest)
    : IQuery<GetUserInfoActionsResult>;

    public record GetUserInfoActionsResult(PaginatedResult<UserInfoDto> Results);
}
