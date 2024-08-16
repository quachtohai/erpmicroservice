using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateDictionaryInfo
{
    public record UpdateDictionaryInfoRequest(DictionaryInfoDto DictionaryInfo);
    public record UpdateDictionaryInfoResponse(bool IsSuccess);
    public class UpdateDictionaryInfoEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/dictionaryinfo/update", async (UpdateDictionaryInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<DictionaryInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateDictionaryInfoResponse>();

                return Results.Ok(response);
            })
         .WithName("DictionaryInfoUpdate")
         .Produces<UpdateDictionaryInfoResponse>(StatusCodes.Status201Created)
         .ProducesProblem(StatusCodes.Status400BadRequest)
         .WithSummary("DictionaryInfoUpdate")
         .WithDescription("DictionaryInfoUpdate");
        }
    }
}
