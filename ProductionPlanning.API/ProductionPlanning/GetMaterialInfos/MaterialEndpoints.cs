using Carter;
using Mapster;
using MediatR;

namespace ProductionPlanning.API.ProductionPlanning.GetMaterialInfos
{
    public record MaterialRequest(string MaterialCode, string MaterialName, string Description);
    public record MaterialResponse(string MaterialCode, string MaterialName, string Description);
    public class MaterialEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/material/list", async (MaterialRequest request, ISender sender) =>
            {
                var command = request.Adapt<MaterialCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<MaterialResponse>();

                return response;
            })
        .WithName("CreateProduct")
        .Produces<MaterialResponse>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create Product")
        .WithDescription("Create Product");
        }
    }
}
