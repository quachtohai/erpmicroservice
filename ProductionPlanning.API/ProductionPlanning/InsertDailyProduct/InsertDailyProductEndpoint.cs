using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.ProductionPlanning.DailyProduct;

namespace ProductionPlanning.API.ProductionPlanning.InsertDailyProduct
{
    public record CreateDailyProductionRequest(DailyProductionDto DailyProduction);
    public record CreateDailyProductionResponse(int Id);

    public class CreateDailyProduction : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            //app.MapPost("/userinfo/create", [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard")]
            app.MapPost("/dailyproduction/create",
            async (CreateDailyProductionRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateDailyProductionCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<CreateDailyProductionResponse>();

                return Results.Created($"/dailyproductions/{response.Id}", response);
            })
            .WithName("CreateDailyProductions")
            .Produces<CreateDailyProductionResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create DailyProduction")
            .WithDescription("Create DailyProduction");

        }
    }
}
