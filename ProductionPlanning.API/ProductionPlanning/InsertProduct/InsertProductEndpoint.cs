using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.InsertProduct
{
    public record InsertProductRequest(ProductDto Product);
    public record InsertProductResponse(int Id);
    public class InsertProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/product/create", async (InsertProductRequest request, ISender sender) =>
            {
                var command = request.Adapt<ProductCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<InsertProductResponse>();

                return Results.Ok(response);
            })
         .WithName("ProductInsert")
         .Produces<InsertProductResponse>(StatusCodes.Status201Created)
         .ProducesProblem(StatusCodes.Status400BadRequest)
         .WithSummary("ProductInsert")
         .WithDescription("ProductInsert");
        }
    }

}
