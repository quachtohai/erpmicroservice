using Authenticaion.Application.Authentication.Queries.GetModules;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetModulesResponse(PaginatedResult<ModuleDto> Modules);
    public class GetModules : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/modules/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetModulesQuery(request));

                var response = result.Adapt<GetModulesResponse>();

                return Results.Ok(response);
            })
        .WithName("GetModules")
        .Produces<GetModulesResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Modules")
        .WithDescription("Get Modules");
        }
    }
}
