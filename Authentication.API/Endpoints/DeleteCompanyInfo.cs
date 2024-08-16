using Authenticaion.Application.Authentication.Commands.DeleteCompanyInfo;

namespace Authentication.API.Endpoints
{
    public record DeleteCompanyInfoResponse(bool IsSuccess);

    public class DeleteCompanyInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/companyinfo/delete/{id}", async (Guid Id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteCompanyInfoCommand(Id));

                var response = result.Adapt<DeleteCompanyInfoResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteCompanyInfo")
            .Produces<DeleteCompanyInfoResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete CompanyInfo")
            .WithDescription("Delete CompanyInfo");
        }
    }
}
