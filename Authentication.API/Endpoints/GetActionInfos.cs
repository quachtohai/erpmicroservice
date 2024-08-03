using Authenticaion.Application.Authentication.Queries.GetActions;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetActionInfosResponse(PaginatedResult<ActionInfoDto> ActionInfos);
    public class GetActionInfos : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/actioninfos/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetActionInfosQuery(request));

                var response = result.Adapt<GetActionInfosResponse>();

                return Results.Ok(response);
            })
        .WithName("GetActionInfos")
        .Produces<GetActionInfosResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get ActionInfos")
        .WithDescription("Get ActionInfos");
        }
    }
}
