using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.GetProductById
{
    public record GetProductByIdResponse(ProductDto Results);
    public class GetProductById : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/product/read/{productid}", async (int productid, ISender sender) =>
            {
                var result = await sender.Send(new GetProductByIdQuery(productid));

                var response = result.Adapt<GetProductByIdResponse>();

                return Results.Ok(response);
            })
        .WithName("GetProductById")
        .Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Products By Id")
        .WithDescription("Get Products By Id");
        }
    }
}
