using Authenticaion.Application.Authentication.Queries.Forms;
using BuildingBlocks.Pagination;

namespace Authentication.API.Endpoints
{
    
        public record GetFormsResponse(PaginatedResult<FormDto> Forms);
        public class GetForms : ICarterModule
        {
            public void AddRoutes(IEndpointRouteBuilder app)
            {
                app.MapGet("/forms/list", async ([AsParameters] PaginationRequest request, ISender sender) =>
                {
                    var result = await sender.Send(new GetFormsQuery(request));

                    var response = result.Adapt<GetFormsResponse>();

                    return Results.Ok(response);
                })
            .WithName("GetForms")
            .Produces<GetFormsResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get Forms")
            .WithDescription("Get Forms");
            }
        }
    
}
