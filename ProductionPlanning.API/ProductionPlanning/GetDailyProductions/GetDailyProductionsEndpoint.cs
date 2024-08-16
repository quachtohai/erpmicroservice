using BuildingBlocks.Pagination;
using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.GetDailyProductions
{
    public record GetDailyProductionsResponse(PaginatedResult<DailyProductionDto> Results);

    public class GetDailyProductions : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/dailyproduction/list", async ([AsParameters] PaginationRequestWithDate request, ISender sender) =>
            {
                var result = await sender.Send(new GetDailyProductionsQuery(request));

                var response = result.Adapt<GetDailyProductionsResponse>();

                return Results.Ok(response);
            })
            .WithName("GetDailyProductions")
            .Produces<GetDailyProductionsResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get DailyProductions")
            .WithDescription("Get DailyProductions");
        }
    }
}
