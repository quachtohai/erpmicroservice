using BuildingBlocks.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Queries.Forms
{
    public record GetFormsQuery(PaginationRequest PaginationRequest)
   : IQuery<GetFormsResult>;

    public record GetFormsResult(PaginatedResult<FormDto> Forms);
}


