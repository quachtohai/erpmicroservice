using Authenticaion.Application.Authentication.Queries.GetUserInfoMenus;
using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoActions
{
    public class GetUserInfoActionsHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetUserInfoActionsQuery, GetUserInfoActionsResult>
    {
        public async Task<GetUserInfoActionsResult> Handle(GetUserInfoActionsQuery query, CancellationToken cancellationToken)
        {

            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.UserInfos.LongCountAsync(cancellationToken);

            var users = await dbContext.UserInfos
                           .Include(o => o.ItemActions)
                           .OrderByDescending(o => o.CreatedAt)
                           .Skip(pageSize * (pageIndex-1))
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);

            return new GetUserInfoActionsResult(
                new PaginatedResult<UserInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    users.ToUserActionInfoDtoList()));
        }
    }
}
