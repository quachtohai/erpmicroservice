using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using BuildingBlocks.Pagination;

namespace Authenticaion.Application.Authentication.Queries.GetCompanyInfos
{
    public class GetCompanyInfosHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetCompanyInfosQuery, GetCompanyInfosResult>
    {
        public async Task<GetCompanyInfosResult> Handle(GetCompanyInfosQuery query, CancellationToken cancellationToken)
        {

            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;
            var filter = query.PaginationRequest.Filter;
            var equal = query.PaginationRequest.Equal;
            var q = query.PaginationRequest.Q;
            var fields = query.PaginationRequest.Fields;

            var filterId = filter + "Id";
            var fromDate = query.PaginationRequest.FromDate;
            var toDate = query.PaginationRequest.ToDate;
            var totalCount = await dbContext.CompanyInfos.LongCountAsync(cancellationToken);


            var companyFinals = new List<CompanyInfo>();
            if (!string.IsNullOrEmpty(filter) && equal != "")
            {
                string[] filterTmp = filter.Split(',');
                foreach (var filterItem in filterTmp)
                {
                    await dbContext.CompanyInfos
                    .ForEachAsync(companyInfo =>
                    {
                        if (companyInfo.GetType().GetProperty(filterItem).GetValue(companyInfo).ToString().Contains(equal.ToString()))

                        {
                            companyFinals.Add(companyInfo);
                        }
                    });

                }

            }
            else if(!string.IsNullOrEmpty(fields) && q != "")
            {
                string[] fieldsTmp  = fields.Split(',');
                foreach (var fieldTmpItem in fieldsTmp)
                {
                    await dbContext.CompanyInfos
                    .ForEachAsync(companyInfo =>
                    {
                        if (companyInfo.GetType().GetProperty(fieldTmpItem).GetValue(companyInfo).ToString().Contains(q.ToString()))

                        {
                            companyFinals.Add(companyInfo);
                        }
                    });

                }
            } 
            else
            {
                companyFinals = await dbContext.CompanyInfos

                           .OrderByDescending(o => o.CreatedAt)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize)
                           .ToListAsync(cancellationToken);
            }
            return new GetCompanyInfosResult(
                new PaginatedResult<CompanyInfoDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    companyFinals.ToCompanyInfoDtoList()));
        }
    }
}
