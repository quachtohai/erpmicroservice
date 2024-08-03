using Authenticaion.Application.Authentication.Queries.GetUserInfoActions;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoActionsResponse(PaginatedResult<UserInfoDto> Results);

    public class GetUserInfoActions : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfomenu/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfoActionsQuery(request));

                var response = result.Adapt<GetUserInfoActionsResponse>();

                return Results.Ok(response);
            })
            .WithName("GetUserInfoActions")
            .Produces<GetUserInfoActionsResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get UserInfoActions")
            .WithDescription("Get UserInfoActions");
        }
    }
}
