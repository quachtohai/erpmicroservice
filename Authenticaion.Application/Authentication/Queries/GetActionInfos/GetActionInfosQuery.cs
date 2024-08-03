using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetActions
{
    public record GetActionInfosQuery(PaginationRequest PaginationRequest)
  : IQuery<GetActionInfosResult>;

    public record GetActionInfosResult(PaginatedResult<ActionInfoDto> ActionInfos);
}
