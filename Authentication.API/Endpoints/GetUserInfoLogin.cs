using Authenticaion.Application.Authentication.Commands.UpdateUserInfo;
using Authenticaion.Application.Authentication.Queries.GetUserLogin;
using Authentication.Domain.Models;
using BuildingBlocks.Pagination;
using System.IdentityModel.Tokens.Jwt;

namespace Authentication.API.Endpoints
{
    public record GetUserInfoLoginRequest(UserLoginDto UserInfo);
    public record GetUserInfoLoginResponse(UserLoginDto Results);

    public class GetUserInfoLogin : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/userinfologin/search", async (GetUserInfoLoginRequest request, ISender sender) =>
            {
                var finalRequest = new GetUserInfoLoginRequest(
                    new UserLoginDto(request.UserInfo.UserName, request.UserInfo.Password,
                        DependencyInjection.key,DependencyInjection.issuer,DependencyInjection.audience,""
                    ));
                var command = finalRequest.Adapt<GetUserLoginQuery>();

                var result = await sender.Send(command);

                var response = result.Adapt<GetUserInfoLoginResponse>();

                return Results.Ok(response);
            })
            .WithName("GetUserLogin")
            .Produces<GetUserInfoLoginResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get UserLogin")
            .WithDescription("Get UserLogin");
        }
    }
}
