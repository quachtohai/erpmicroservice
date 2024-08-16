using Authenticaion.Application.Authentication.Commands.CreateUserInfo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.API.Endpoints
{
    public record CreateUserInfoRequest(UserInfoDto UserInfo);
    public record CreateUserInfoResponse(Guid Id);

    public class CreateUserInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            //app.MapPost("/userinfo/create", [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard")]
            app.MapPost("/userinfo/create", 
            async (CreateUserInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateUserInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<CreateUserInfoResponse>();

                return Results.Created($"/userinfos/{response.Id}", response);
            })
            .WithName("CreateUserInfo")
            .Produces<CreateUserInfoResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create UserInfo")
            .WithDescription("Create UserInfo");

        }
    }
}

