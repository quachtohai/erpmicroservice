using Authenticaion.Application.Authentication.Queries.GetUserInfoMenus;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoMenusResponse(PaginatedResult<UserInfoDto> Results);

    public class GetUserInfoMenus : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfoaction/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfoMenusQuery(request));

                var response = result.Adapt<GetUserInfoMenusResponse>();

                return Results.Ok(response);
            })
            .WithName("GetUserInfoMenus")
            .Produces<GetUserInfoMenusResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get UserInfoMenus")
            .WithDescription("Get UserInfoMenus");
        }
    }
}
