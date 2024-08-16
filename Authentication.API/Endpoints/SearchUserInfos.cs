using Authenticaion.Application.Authentication.Queries.SearchUserInfos;
using BuildingBlocks.Pagination;
using BuildingBlocks.Search;

namespace Authentication.API.Endpoints
{
    public record SearchUserInfosResponse(SearchResult<UserInfoDto> Results);

    public class SearchUserInfos : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/userinfo/search", async ([AsParameters] SearchRequest request, ISender sender) =>
            {
                var result = await sender.Send(new SearchUserInfosQuery(request));

                var response = result.Adapt<SearchUserInfosResponse>();

                return Results.Ok(response);
            })
            .WithName("SearchUserInfos")
            .Produces<SearchUserInfosResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Search UserInfos")
            .WithDescription("Search UserInfos");
        }
    }
}
