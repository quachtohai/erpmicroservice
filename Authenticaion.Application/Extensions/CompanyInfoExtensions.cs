using Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Extensions
{
    public static class CompanyInfoExtensions
    {
        public static IEnumerable<CompanyInfoDto> ToCompanyInfoDtoList(this IEnumerable<CompanyInfo> companyInfos)
        {
            return companyInfos.Select(companyInfo => new CompanyInfoDto(
               Id: companyInfo.Id.Value,
               Name: companyInfo.Name,
               Contact: companyInfo.Contact,
               Country: companyInfo.Country,
               Phone: companyInfo.Phone,
               Email: companyInfo.Email,
               Website: companyInfo.Website,
               Description: companyInfo.Description,
                Description2: companyInfo.Description2,
                Description3: companyInfo.Description3,
                Description4: companyInfo.Description4,
                Description5: companyInfo.Description5


            ));
        }
    }
}
