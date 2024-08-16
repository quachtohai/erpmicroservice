using Authenticaion.Application.Authentication.Commands.CreateCompany;

namespace Authentication.API.Endpoints
{
    public record CreateCompanyInfoRequest(CompanyInfoDto CompanyInfo);
    public record CreateCompanyInfoResponse(Guid Id);

    public class CreateCompanyInfo : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            //app.MapPost("/userinfo/create", [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard")]
            app.MapPost("/companyinfo/create",
            async (CreateCompanyInfoRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateCompanyInfoCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<CreateCompanyInfoResponse>();

                return Results.Created($"/companyInfos/{response.Id}", response);
            })
            .WithName("CreateCompanyInfo")
            .Produces<CreateCompanyInfoResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create CompanyInfo")
            .WithDescription("Create CompanyInfo");

        }
    }
}
