using Authenticaion.Application.Authentication.Queries.GetModules;
using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.Forms
{
    public class GetFormsHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetFormsQuery, GetFormsResult>
    {

        public async Task<GetFormsResult> Handle(GetFormsQuery query, CancellationToken cancellationToken)
        {
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.Forms.LongCountAsync(cancellationToken);

            var forms = await dbContext.Forms.OrderBy(x => x.Order).
                ToListAsync();

            return new GetFormsResult(
                new PaginatedResult<FormDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    forms.ToFormDtoList()));
        }
    }
}
