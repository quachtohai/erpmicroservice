using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticaion.Application.Authentication.Commands.UpdateCompanyInfo
{
    public record UpdateCompanyInfoCommand(CompanyInfoDto CompanyInfo)
     : ICommand<UpdateCompanyInfoResult>;
    public record UpdateCompanyInfoResult(bool IsSuccess);

    public class UpdateCompanyInfoCommandValidator : AbstractValidator<UpdateCompanyInfoCommand>
    {
        public UpdateCompanyInfoCommandValidator()
        {
            RuleFor(x => x.CompanyInfo.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
