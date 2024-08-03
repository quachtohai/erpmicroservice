using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.InsertMaterialInfo
{
    public record InsertMaterialInfoRequest(MaterialInfoDto MaterialInfoDto);
    public record InsertMaterialInfoResponse(bool IsSuccess);
    public class InsertMaterialInfoEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/material/insert", async (InsertMaterialInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<MaterialInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<InsertMaterialInfoResponse>();

                return Results.Ok(response);
            })
         .WithName("MaterialInfoInsert")
         .Produces<InsertMaterialInfoResponse>(StatusCodes.Status201Created)
         .ProducesProblem(StatusCodes.Status400BadRequest)
         .WithSummary("MaterialInfoInsert")
         .WithDescription("MaterialInfoInsert");
        }
    }
}
