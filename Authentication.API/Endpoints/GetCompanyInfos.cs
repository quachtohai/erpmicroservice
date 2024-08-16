using Authenticaion.Application.Authentication.Queries.GetCompanyInfos;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetCompanyInfosResponse(PaginatedResult<CompanyInfoDto> Results);

    public class GetCompanyInfos : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/companyinfo/list", async ([AsParameters] PaginationRequestWithDate request, ISender sender) =>
            {
               var result = await sender.Send(new GetCompanyInfosQuery(request));

                var response = result.Adapt<GetCompanyInfosResponse>();

                return Results.Ok(response);
            })
            .WithName("GetCompanyInfos")
            .Produces<GetCompanyInfosResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get CompanyInfos")
            .WithDescription("Get CompanyInfos");
        }
    }
}
