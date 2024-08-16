using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.InsertDictionaryInfo
{
    public record InsertDictionaryInfoRequest(DictionaryInfoDto DictionaryInfo);
    public record InsertDictionaryInfoResponse(int Id);
    public class InsertDictionaryInfoEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/dictionaryinfo/create", async (InsertDictionaryInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<DictionaryInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<InsertDictionaryInfoResponse>();

                return Results.Ok(response);
            })
         .WithName("DictionaryInfoInsert")
         .Produces<InsertDictionaryInfoResponse>(StatusCodes.Status201Created)
         .ProducesProblem(StatusCodes.Status400BadRequest)
         .WithSummary("DictionaryInfoInsert")
         .WithDescription("DictionaryInfoInsert");
        }
    }
}
