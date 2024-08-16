using Authenticaion.Application.Authentication.Commands.UpdateUserInfo;
using Authenticaion.Application.Exceptions;
using Authentication.Domain.Models;
using Authentication.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateCompanyInfo
{
    public class UpdateCompanyInfoHandler(IApplicationDbContext dbContext)
     : ICommandHandler<UpdateCompanyInfoCommand, UpdateCompanyInfoResult>
    {
        public async Task<UpdateCompanyInfoResult> Handle(UpdateCompanyInfoCommand command, CancellationToken cancellationToken)
        {

            var companyInfoId = CompanyInfoId.Of(command.CompanyInfo.Id);
            var companyInfo = await dbContext.CompanyInfos
                .FindAsync([companyInfoId], cancellationToken: cancellationToken);

            if (companyInfo is null)
            {
                throw new UserNotFoundException(command.CompanyInfo.Id);
            }

            UpdateCompanyInfoWithNewValues(companyInfo, command.CompanyInfo);

            dbContext.CompanyInfos.Update(companyInfo);

            await dbContext.SaveChangesAsync(cancellationToken);

            return new UpdateCompanyInfoResult(true);
        }

        public void UpdateCompanyInfoWithNewValues(CompanyInfo companyInfo, CompanyInfoDto companyInfoDto)
        {


            companyInfo.Update(companyInfoDto.Name, companyInfoDto.Contact, companyInfoDto.Country, companyInfoDto.Phone, companyInfoDto.Email,
                companyInfoDto.Website, "", "", "", "", "");
        }




    }
}
