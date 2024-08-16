using BuildingBlocks.Pagination;
using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.GetDictionaryInfos
{
    public record GetDictionaryInfosResponse(PaginatedResult<DictionaryInfoDto> Results);
    public class GetDictionaryInfos : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/dictionaryinfo/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetDictionaryInfosQuery(request));

                var response = result.Adapt<GetDictionaryInfosResponse>();

                return Results.Ok(response);
            })
        .WithName("GetDictionaryInfos")
        .Produces<GetDictionaryInfosResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get DictionaryInfos")
        .WithDescription("Get DictionaryInfos");
        }
    }
}
