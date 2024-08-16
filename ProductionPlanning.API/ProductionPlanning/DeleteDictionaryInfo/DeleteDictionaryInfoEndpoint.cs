using Carter;
using Mapster;
using MediatR;

namespace ProductionPlanning.API.ProductionPlanning.DeleteDictionaryInfo
{
    public record DeleteDictionaryInfoResponse(bool IsSuccess);

    public class DeleteDictionaryInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/dictionaryinfo/delete/{id}", async (int Id, ISender sender) =>
            {
                var result = await sender.Send(new DictionaryInfoCommand(Id));

                var response = result.Adapt<DeleteDictionaryInfoResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteDictionaryInfo")
            .Produces<DeleteDictionaryInfoResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete DictionaryInfo")
            .WithDescription("Delete DictionaryInfo");
        }
    }
}
