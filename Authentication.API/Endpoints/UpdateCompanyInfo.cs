using Authenticaion.Application.Authentication.Commands.UpdateCompanyInfo;

namespace Authentication.API.Endpoints
{
    public record UpdateCompanyInfoRequest(CompanyInfoDto CompanyInfo);
    public record UpdateCompanyInfoResponse(bool IsSuccess);

    public class UpdateCompanyInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/companyinfo/update", async (UpdateCompanyInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<UpdateCompanyInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<UpdateCompanyInfoResponse>();

                return Results.Ok(response);
            })
            .WithName("UpdateCompanyInfo")
            .Produces<UpdateCompanyInfoResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Update CompanyInfo")
            .WithDescription("Update CompanyInfo");
        }
    }
}
