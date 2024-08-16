using Carter;
using Mapster;
using MediatR;

namespace ProductionPlanning.API.ProductionPlanning.DeleteProduct
{
    public record DeleteProductResponse(bool IsSuccess);

    public class DeleteProduct : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/product/delete/{id}", async (int Id, ISender sender) =>
            {
                var result = await sender.Send(new ProductCommand(Id));

                var response = result.Adapt<DeleteProductResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteProduct")
            .Produces<DeleteProductResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete Product")
            .WithDescription("Delete Product");
        }
    }
}
