using Authenticaion.Application.Authentication.Commands.CreateUserInfo;
using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.CreateCompany
{
    public class CreateCompanyInfoHandler(IApplicationDbContext dbContext)
      : ICommandHandler<CreateCompanyInfoCommand, CreateCompanyInfoResult>
    {
        public async Task<CreateCompanyInfoResult> Handle(CreateCompanyInfoCommand command, CancellationToken cancellationToken)
        {


            var companyInfo = CreateNewCompanyInfo(command.CompanyInfo);

            dbContext.CompanyInfos.Add(companyInfo);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateCompanyInfoResult(companyInfo.Id.Value);
        }

        private CompanyInfo CreateNewCompanyInfo(CompanyInfoDto companyInfoDto)
        {


            var newCompanyInfo = CompanyInfo.Create(
                    id: CompanyInfoId.Of(Guid.NewGuid()),
                    name: companyInfoDto.Name,
                    contact:companyInfoDto.Contact,
                    country:companyInfoDto.Country,
                    phone:companyInfoDto.Phone,
                    email:companyInfoDto.Email,
                    website:companyInfoDto.Website,
                    description:string.Empty,
                    description2:string.Empty,
                    description3:string.Empty,
                    description4:string.Empty,
                    description5:string.Empty

                    );

            return newCompanyInfo;
        }
    }
}
