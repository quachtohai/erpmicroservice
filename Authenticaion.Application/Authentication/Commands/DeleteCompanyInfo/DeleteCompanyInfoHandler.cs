using Authenticaion.Application.Exceptions;
using Authentication.Domain.ValueObjects;

namespace Authenticaion.Application.Authentication.Commands.DeleteCompanyInfo
{
    public class DeleteCompanyInfoHandler(IApplicationDbContext dbContext)
      : ICommandHandler<DeleteCompanyInfoCommand, DeleteCompanyInfoResult>
    {
        public async Task<DeleteCompanyInfoResult> Handle(DeleteCompanyInfoCommand command, CancellationToken cancellationToken)
        {

            var companyInfoId = CompanyInfoId.Of(command.CompanyInfoId);
            var company = await dbContext.CompanyInfos
                .FindAsync([companyInfoId], cancellationToken: cancellationToken);

            if (company is null)
            {
                throw new UserNotFoundException(command.CompanyInfoId);
            }

            
            dbContext.CompanyInfos.Remove(company);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new DeleteCompanyInfoResult(true);
        }
    }
}
