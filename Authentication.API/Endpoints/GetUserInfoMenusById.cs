using Authenticaion.Application.Authentication.Queries.GetUserInfoMenusById;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoMenusByIdResponse(UserInfoDto Results);
    public class GetUserInfoMenusById : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfomenu/read/{userInfoId}", async (Guid userInfoId, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfoMenusByIdQuery(userInfoId));

                var response = result.Adapt<GetUserInfoMenusByIdResponse>();

                return Results.Ok(response);
            })
        .WithName("GetUserInfoMenusById")
        .Produces<GetUserInfoMenusByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get UserInfoMenus By Id")
        .WithDescription("Get UserInfoMenus By Idr");
        }
    }
}
