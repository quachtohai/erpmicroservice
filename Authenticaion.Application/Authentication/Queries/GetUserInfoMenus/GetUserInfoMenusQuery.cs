using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoMenus
{
    public record GetUserInfoMenusQuery(PaginationRequest PaginationRequest)
    : IQuery<GetUserInfoMenusResult>;

    public record GetUserInfoMenusResult(PaginatedResult<UserInfoDto> Results);
}
