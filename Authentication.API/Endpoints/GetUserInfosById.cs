
using Authenticaion.Application.Authentication.Queries.GetUserInfosById;

namespace Authentication.API.Endpoints
{
    public record GetUserInfosByIdResponse(UserInfoDto Results);
    public class GetUserInfosById : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfo/read/{userInfoId}", async (Guid userInfoId, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfosByIdQuery(userInfoId));

                var response = result.Adapt<GetUserInfosByIdResponse>();

                return Results.Ok(response);
            })
        .WithName("GetUserInfosById")
        .Produces<GetUserInfosByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get UserInfos By Id")
        .WithDescription("Get UserInfos By Id");
        }
    }
}
