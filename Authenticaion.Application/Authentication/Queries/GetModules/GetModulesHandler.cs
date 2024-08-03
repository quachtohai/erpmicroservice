using Authenticaion.Application.Authentication.Queries.GetModules;
using Authenticaion.Application.Data;
using Authenticaion.Application.Dtos;
using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;

namespace Authenticaion.Application.Authentication.Queries.GetModules
{
    public class GetModulesHandler(IApplicationDbContext dbContext)
     : IQueryHandler<GetModulesQuery, GetModulesResult>
    {

        public async Task<GetModulesResult> Handle(GetModulesQuery query, CancellationToken cancellationToken)
        {
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = await dbContext.Modules.LongCountAsync(cancellationToken);

            var modules = await dbContext.Modules.OrderBy(x=>x.Order).              
                ToListAsync();

            return new GetModulesResult(
                new PaginatedResult<ModuleDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    modules.ToModuleDtoList()));
        }
    }
}
