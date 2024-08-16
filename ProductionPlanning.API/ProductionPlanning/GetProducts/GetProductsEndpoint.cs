using BuildingBlocks.Pagination;
using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.GetProducts
{
    public record GetProductsResponse(PaginatedResult<ProductDto> Results);
    public class GetProducts : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/product/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetProductsQuery(request));

                var response = result.Adapt<GetProductsResponse>();

                return Results.Ok(response);
            })
        .WithName("GetProducts")
        .Produces<GetProductsResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Products")
        .WithDescription("Get Products");
        }
    }
}
