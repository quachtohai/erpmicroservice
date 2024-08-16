using BuildingBlocks.Search;
using Carter;
using Mapster;
using MediatR;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.SearchProducts
{
    public record SearchProductsResponse(SearchResult<ProductDto> Results);

    public class SearchProducts : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/product/search", async ([AsParameters] SearchRequest request, ISender sender) =>
            {
                var result = await sender.Send(new SearchProductsQuery(request));

                var response = result.Adapt<SearchProductsResponse>();

                return Results.Ok(response);
            })
            .WithName("SearchProducts")
            .Produces<SearchProductsResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Search Products")
            .WithDescription("Search Products");
        }
    }
}
