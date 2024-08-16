using Authenticaion.Application.Authentication.Queries.UserInfos;
using BuildingBlocks.Pagination;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetUserInfoMenus
{
    
    public class GetUserInfoMenusHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetUserInfoMenusQuery, GetUserInfoMenusResult>
    {
        public async Task<GetUserInfoMenusResult> Handle(GetUserInfoMenusQuery query, CancellationToken cancellationToken)
        {
          
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.UserInfos.LongCountAsync(cancellationToken);

            var users = await dbContext.UserInfos
                           .Include(o => o.ItemMenus)
                           .OrderByDescending(o => o.CreatedAt)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);

            return new GetUserInfoMenusResult(
                new PaginatedResult<UserInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    users.ToUserMenuInfoDtoList()));
        }
    }
}
