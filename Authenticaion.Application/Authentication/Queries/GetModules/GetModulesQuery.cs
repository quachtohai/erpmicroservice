using Authenticaion.Application.Dtos;
using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;

namespace Authenticaion.Application.Authentication.Queries.GetModules
{
    public record GetModulesQuery(PaginationRequest PaginationRequest)
  : IQuery<GetModulesResult>;

    public record GetModulesResult(PaginatedResult<ModuleDto> Modules);
}
