using Authenticaion.Application.Authentication.Queries.GetUserInfoActionsById;
using Authenticaion.Application.Authentication.Queries.GetUserInfoMenusById;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoActionsByIdResponse(UserInfoDto Results);
    public class GetUserInfoActionsById : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfoaction/read/{userInfoId}", async (Guid userInfoId, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfoActionsByIdQuery(userInfoId));

                var response = result.Adapt<GetUserInfoActionsByIdResponse>();

                return Results.Ok(response);
            })
        .WithName("GetUserInfoActionsById")
        .Produces<GetUserInfoActionsByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get UserInfoActions By Id")
        .WithDescription("Get UserInfoActions By Id");
        }
    }
}
