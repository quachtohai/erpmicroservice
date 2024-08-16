using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.UserInfos
{
    public record GetUserInfosQuery(PaginationRequestWithDate PaginationRequest)
    : IQuery<GetUserInfosResult>;

    public record GetUserInfosResult(PaginatedResult<UserInfoDto> Results);
}
