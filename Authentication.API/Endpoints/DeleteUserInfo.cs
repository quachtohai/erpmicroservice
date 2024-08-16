using Authenticaion.Application.Authentication.Commands.DeleteUserInfo;
using Authenticaion.Application.Authentication.Queries.GetUserInfosById;

namespace Authentication.API.Endpoints
{
    public record DeleteUserInfoResponse(bool IsSuccess);

    public class DeleteUserInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/userinfo/delete/{id}", async (Guid Id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteUserInfoCommand(Id));

                var response = result.Adapt<DeleteUserInfoResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteUserInfo")
            .Produces<DeleteUserInfoResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete UserInfo")
            .WithDescription("Delete UserInfo");
        }
    }
}
