using Authenticaion.Application.Authentication.Commands.UpdateUserInfo;
using Authenticaion.Application.Authentication.Commands.UpdateUserInfoMenu;

namespace Authentication.API.Endpoints
{
    public record UpdateUserInfoMenuRequest(UserInfoDto UserInfo);
    public record UpdateUserInfoMenuResponse(bool IsSuccess);

    public class UpdateUserInfoMenu : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/userinfomenu/update", async (UpdateUserInfoMenuRequest request, ISender sender) =>
            {
                var command = request.Adapt<UpdateUserInfoMenuCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateUserInfoMenuResponse>();

                return Results.Ok(response);
            })
            .WithName("UpdateUserInfoMenu")
            .Produces<UpdateUserInfoMenuResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Update UserInfoMenu")
            .WithDescription("Update UserInfoMenu");
        }
    }
}
