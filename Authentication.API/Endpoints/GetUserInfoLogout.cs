using Authenticaion.Application.Authentication.Queries.GetUserLogin;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoLogoutRequest(UserLoginDto UserInfo);
    public record GetUserInfoLogoutResponse(UserLoginDto Results);

    public class GetUserInfoLogout : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/userinfologout/search", async (GetUserInfoLogoutRequest request, ISender sender) =>
            {
                var finalRequest = new GetUserInfoLogoutRequest(
                    new UserLoginDto(request.UserInfo.UserName, request.UserInfo.Password,
                        DependencyInjection.key, DependencyInjection.issuer, DependencyInjection.audience, ""
                    ));
                var command = finalRequest.Adapt<GetUserLoginQuery>();

                var result = await sender.Send(command);

                var response = result.Adapt<GetUserInfoLoginResponse>();

                return Results.Ok(response);
            })
            .WithName("GetUserLogout")
            .Produces<GetUserInfoLoginResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get UserLogout")
            .WithDescription("Get UserLogout");
        }
    }
}
