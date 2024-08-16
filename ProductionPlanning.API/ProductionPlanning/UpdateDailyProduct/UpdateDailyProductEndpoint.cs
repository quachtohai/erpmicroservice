using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateDailyProduct
{
    public record UpdateDailyProductionRequest(DailyProductionDto DailyProduction);
    public record UpdateDailyProductionResponse(bool IsSuccess);

    public class UpdateDailyProduction : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/dailyproduction/update", async (UpdateDailyProductionRequest request, ISender sender) =>
            {
                var command = request.Adapt<UpdateDailyProductionCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateDailyProductionResponse>();

                return Results.Ok(response);
            })
            .WithName("UpdateDailyProductionResponse")
            .Produces<UpdateDailyProductionResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Update DailyProduction")
            .WithDescription("Update DailyProduction");
        }
    }
}
