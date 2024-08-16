using Carter;
using Mapster;
using MediatR;

namespace ProductionPlanning.API.ProductionPlanning.DeleteDailyProduction
{
    public record DeleteDailyProductionResponse(bool IsSuccess);

    public class DeleteDailyProduction : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/dailyproduction/delete/{id}", async (int Id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteDailyProductionCommand(Id));

                var response = result.Adapt<DeleteDailyProductionResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteDailyProduction")
            .Produces<DeleteDailyProductionResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete DailyProduction")
            .WithDescription("Delete DailyProduction");
        }
    }
}
