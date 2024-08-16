using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using BuildingBlocks.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Authenticaion.Application.Authentication.Queries.UserInfos
{
    public class GetUserInfosHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetUserInfosQuery, GetUserInfosResult>
    {
        public async Task<GetUserInfosResult> Handle(GetUserInfosQuery query, CancellationToken cancellationToken)
        {

            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;
            var filter = query.PaginationRequest.Filter;
            var equal = query.PaginationRequest.Equal;
           
            var filterId = filter + "Id";
            var fromDate = query.PaginationRequest.FromDate;
            var toDate = query.PaginationRequest.ToDate;
            var totalCount = await dbContext.UserInfos.LongCountAsync(cancellationToken);


            var userFinals = new List<UserInfo>();
            if (!string.IsNullOrEmpty(filter) && equal != "")
            {
                await dbContext.UserInfos
                    .Include(o => o.Items)
                    .Include(x => x.ItemActions)
                    .Include(y => y.ItemMenus)
                    .ForEachAsync(userInfo =>
                    {
                        if (userInfo.GetType().GetProperty("Id").GetValue(userInfo).Equals(UserInfoId.Of(new Guid(equal))))
                        {
                            userFinals.Add(userInfo);
                        }
                    });
            }
            else
            {
                userFinals =await dbContext.UserInfos
                           .Include(o => o.Items)
                           .Include(x => x.ItemActions)
                           .Include(y => y.ItemMenus)

                           .OrderByDescending(o => o.CreatedAt)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);
            }
            return new GetUserInfosResult(
                new PaginatedResult<UserInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    userFinals.ToUserInfoDtoList()));
        }
    }
}
