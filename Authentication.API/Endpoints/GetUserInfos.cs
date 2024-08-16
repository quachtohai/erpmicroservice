using Authenticaion.Application.Authentication.Queries.UserInfos;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    public record GetUserInfosResponse(PaginatedResult<UserInfoDto> Results);

    public class GetUserInfos : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfo/list", async ([AsParameters] PaginationRequestWithDate request, ISender sender) =>
            {
                var result = await sender.Send(new GetUserInfosQuery(request));

                var response = result.Adapt<GetUserInfosResponse>();

                return Results.Ok(response);
            })
            .WithName("GetUserInfos")
            .Produces<GetUserInfosResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get UserInfos")
            .WithDescription("Get UserInfos");
        }
    }
}
