using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateProduct
{

    public record UpdateProductRequest(ProductDto Product);
    public record UpdateProductResponse(bool IsSuccess);
    public class UpdateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/product/update", async (UpdateProductRequest request, ISender sender) =>
            {
                var command = request.Adapt<ProductCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateProductResponse>();

                return Results.Ok(response);
            })
         .WithName("ProductUpdate")
         .Produces<UpdateProductResponse>(StatusCodes.Status201Created)
         .ProducesProblem(StatusCodes.Status400BadRequest)
         .WithSummary("ProductUpdate")
         .WithDescription("ProductUpdate");
        }
    }
}

