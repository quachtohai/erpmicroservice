using Authenticaion.Application.Authentication.Commands.UpdateUserInfo;

namespace Authentication.API.Endpoints
{
    public record UpdateUserInfoRequest(UserInfoDto UserInfo);
    public record UpdateUserInfoResponse(bool IsSuccess);

    public class UpdateUserInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/userinfo/update", async (UpdateUserInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<UpdateUserInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateUserInfoResponse>();

                return Results.Ok(response);
            })
            .WithName("UpdateUserInfo")
            .Produces<UpdateUserInfoResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Update UserInfo")
            .WithDescription("Update UserInfo");
        }
    }
}
