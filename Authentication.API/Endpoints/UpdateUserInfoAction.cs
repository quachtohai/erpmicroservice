using Authenticaion.Application.Authentication.Commands.UpdateUserInfoAction;
using Authenticaion.Application.Authentication.Commands.UpdateUserInfoMenu;

namespace Authentication.API.Endpoints
{
    public record UpdateUserInfoActionRequest(UserInfoDto UserInfo);
    public record UpdateUserInfoActionResponse(bool IsSuccess);

    public class UpdateUserInfoAction : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/userinfoaction/update", async (UpdateUserInfoActionRequest request, ISender sender) =>
            {
                var command = request.Adapt<UpdateUserInfoActionCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateUserInfoActionResponse>();

                return Results.Ok(response);
            })
            .WithName("UpdateUserInfoAction")
            .Produces<UpdateUserInfoActionResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Update UserInfoAction")
            .WithDescription("Update UserInfoAction");
        }
    }
}
