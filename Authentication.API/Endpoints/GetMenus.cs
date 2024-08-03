
using Authenticaion.Application.Authentication.Queries.GetMenus;
using Authenticaion.Application.Dtos;
using BuildingBlocks.Pagination;




namespace Authentication.API.Endpoints
{
    public record GetMenusResponse(PaginatedResult<MenuDto> Menus);
    public class GetMenus : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/menus/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetMenusQuery(request));

                var response = result.Adapt<GetMenusResponse>();

                return Results.Ok(response);
            })
        .WithName("GetMenus")
        .Produces<GetMenusResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Menus")
        .WithDescription("Get Menus");
        }
    }
}
