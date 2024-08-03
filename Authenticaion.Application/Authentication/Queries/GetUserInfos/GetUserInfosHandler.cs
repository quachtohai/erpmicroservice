using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.UserInfos
{
    public class GetUserInfosHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetUserInfosQuery, GetUserInfosResult>
    {
        public async Task<GetUserInfosResult> Handle(GetUserInfosQuery query, CancellationToken cancellationToken)
        {
            
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.UserInfos.LongCountAsync(cancellationToken);

            var orders = await dbContext.UserInfos
                           .Include(o => o.Items)
                           .Include(x=>x.ItemActions)
                           .Include(y=>y.ItemMenus)
                           .OrderByDescending(o => o.CreatedAt)
                           .Skip(pageSize * pageIndex)
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);

            return new GetUserInfosResult(
                new PaginatedResult<UserInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    orders.ToUserInfoDtoList()));
        }
    }
}
