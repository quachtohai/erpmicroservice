using Authenticaion.Application.Authentication.Queries.Forms;
using BuildingBlocks.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetActions
{
    public class GetActionInfosHandler(IApplicationDbContext dbContext)
        : IQueryHandler<GetActionInfosQuery, GetActionInfosResult>
    {
        public  async Task<GetActionInfosResult> Handle(GetActionInfosQuery query, CancellationToken cancellationToken)
        {
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.ActionInfos.LongCountAsync(cancellationToken);

            var actionInfos = await dbContext.ActionInfos.OrderBy(x => x.Order).
                ToListAsync();

            return new GetActionInfosResult(
                new PaginatedResult<ActionInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    actionInfos.ToActionInfoDtoList()));
        }
    }
}
