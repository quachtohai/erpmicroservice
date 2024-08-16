using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.GetCompanyInfos
{
    public record GetCompanyInfosQuery(PaginationRequestWithDate PaginationRequest)
      : IQuery<GetCompanyInfosResult>;

    public record GetCompanyInfosResult(PaginatedResult<CompanyInfoDto> Results);
}
