using Authenticaion.Application.Data;
using Authenticaion.Application.Dtos;
using Authenticaion.Application.Extensions;
using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetMenus
{
    public class GetMenusHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetMenusQuery, GetMenusResult>
    {     

        public async Task<GetMenusResult>  Handle(GetMenusQuery query, CancellationToken cancellationToken)
        {
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.Menus.LongCountAsync(cancellationToken);

            var menus = await dbContext.Menus.ToListAsync();        
           
            return new GetMenusResult(
                new PaginatedResult<MenuDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    menus.ToMenuDtoList()));
        }
    }
}
