using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.GetDictionaryInfoById
{
    public record GetDictionaryInfoByIdResponse(DictionaryInfoDto Results);
    public class GetDictionaryInfoById : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/dictionaryinfo/read/{dictionaryinfoid}", async (int dictionaryinfoid, ISender sender) =>
            {
                var result = await sender.Send(new GetDictionaryInfoByIdQuery(dictionaryinfoid));

                var response = result.Adapt<GetDictionaryInfoByIdResponse>();

                return Results.Ok(response);
            })
        .WithName("GetDictionaryInfoById")
        .Produces<GetDictionaryInfoByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get DictionaryInfos By Id")
        .WithDescription("Get DictionaryInfs By Id");
        }
    }
}
